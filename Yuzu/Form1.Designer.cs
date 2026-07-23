namespace YuzuLauncher
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblKeysStatus = new System.Windows.Forms.Label();
            this.lstGames      = new System.Windows.Forms.ListBox();
            this.btnLaunch     = new System.Windows.Forms.Button();
            this.btnRefresh    = new System.Windows.Forms.Button();
            this.btnAddDir     = new System.Windows.Forms.Button();
            this.btnOpenKeys   = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblKeysStatus.Location = new System.Drawing.Point(12, 12);
            this.lblKeysStatus.Size     = new System.Drawing.Size(560, 22);

            this.lstGames.Location   = new System.Drawing.Point(12, 44);
            this.lstGames.Size       = new System.Drawing.Size(560, 180);

            this.btnLaunch.Text      = "Launch Yuzu";
            this.btnLaunch.Location  = new System.Drawing.Point(12, 238);
            this.btnLaunch.Size      = new System.Drawing.Size(130, 34);

            this.btnRefresh.Text     = "Refresh";
            this.btnRefresh.Location = new System.Drawing.Point(154, 238);
            this.btnRefresh.Size     = new System.Drawing.Size(90, 34);

            this.btnAddDir.Text      = "Add Folder";
            this.btnAddDir.Location  = new System.Drawing.Point(256, 238);
            this.btnAddDir.Size      = new System.Drawing.Size(100, 34);

            this.btnOpenKeys.Text    = "Open Keys Folder";
            this.btnOpenKeys.Location = new System.Drawing.Point(368, 238);
            this.btnOpenKeys.Size    = new System.Drawing.Size(140, 34);

            this.btnLaunch.Click    += new System.EventHandler(this.btnLaunch_Click);
            this.btnRefresh.Click   += new System.EventHandler(this.btnRefresh_Click);
            this.btnAddDir.Click    += new System.EventHandler(this.btnAddDir_Click);
            this.btnOpenKeys.Click  += new System.EventHandler(this.btnOpenKeys_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblKeysStatus, this.lstGames,
                this.btnLaunch, this.btnRefresh, this.btnAddDir, this.btnOpenKeys });

            this.Text          = "Yuzu Emulator Launcher";
            this.ClientSize    = new System.Drawing.Size(586, 288);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label   lblKeysStatus;
        private System.Windows.Forms.ListBox lstGames;
        private System.Windows.Forms.Button  btnLaunch;
        private System.Windows.Forms.Button  btnRefresh;
        private System.Windows.Forms.Button  btnAddDir;
        private System.Windows.Forms.Button  btnOpenKeys;
    }
}
