using System;
using System.Diagnostics;
using System.IO;

namespace YuzuLauncher
{
    public static class EmulatorLauncher
    {
        public static void Launch(string yuzuExePath, string romPath = null)
        {
            if (!File.Exists(yuzuExePath))
                throw new FileNotFoundException("Yuzu executable not found.", yuzuExePath);

            var args = romPath != null ? $"\"{romPath}\"" : string.Empty;
            var psi  = new ProcessStartInfo(yuzuExePath, args)
            {
                UseShellExecute        = true,
                WorkingDirectory       = Path.GetDirectoryName(yuzuExePath)
            };
            Process.Start(psi);
        }

        public static bool IsRunning()
        {
            return Process.GetProcessesByName("yuzu").Length > 0
                || Process.GetProcessesByName("yuzu-cmd").Length > 0;
        }
    }
}
