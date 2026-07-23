using System;
using System.IO;
using System.Windows.Forms;

namespace YuzuLauncher
{
    public partial class MainForm : Form
    {
        private readonly GameLibrary _library = new GameLibrary();

        public MainForm()
        {
            InitializeComponent();
            LoadDefaultDirectories();
            RefreshStatus();
        }

        private void LoadDefaultDirectories()
        {
            string gamesPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Games");
            if (Directory.Exists(gamesPath)) _library.AddDirectory(gamesPath);
        }

        private void RefreshStatus()
        {
            var keysError = KeysValidator.DetectMissingKeys();
            lblKeysStatus.Text      = keysError ?? "prod.keys: OK";
            lblKeysStatus.ForeColor = keysError == null
                ? System.Drawing.Color.LimeGreen
                : System.Drawing.Color.OrangeRed;

            lstGames.Items.Clear();
            foreach (var game in _library.Scan())
                lstGames.Items.Add($"{game.Name}  [{game.Extension}]  {game.SizeBytes / 1048576} MB");
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            string exe = Path.Combine(Application.StartupPath, "yuzu.exe");
            if (!File.Exists(exe)) { MessageBox.Show("yuzu.exe not found."); return; }
            EmulatorLauncher.Launch(exe);
        }

        private void btnRefresh_Click(object sender, EventArgs e) => RefreshStatus();

        private void btnAddDir_Click(object sender, EventArgs e)
        {
            using var dlg = new FolderBrowserDialog { Description = "Select game directory" };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _library.AddDirectory(dlg.SelectedPath);
                RefreshStatus();
            }
        }

        private void btnOpenKeys_Click(object sender, EventArgs e)
        {
            string dir = Path.GetDirectoryName(KeysValidator.GetKeysPath());
            Directory.CreateDirectory(dir);
            System.Diagnostics.Process.Start("explorer.exe", dir);
        }
    }
}
