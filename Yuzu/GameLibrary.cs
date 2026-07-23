using System;
using System.IO;
using System.Collections.Generic;

namespace YuzuLauncher
{
    public class GameLibrary
    {
        public class GameEntry
        {
            public string Name       { get; set; }
            public string FilePath   { get; set; }
            public string Extension  { get; set; } // .nsp, .xci, .nca
            public long   SizeBytes  { get; set; }
        }

        private readonly List<string> _directories = new();

        public void AddDirectory(string path)
        {
            if (Directory.Exists(path) && !_directories.Contains(path))
                _directories.Add(path);
        }

        public IEnumerable<GameEntry> Scan()
        {
            var supported = new[] { ".nsp", ".xci", ".nca" };
            foreach (var dir in _directories)
            {
                foreach (var ext in supported)
                {
                    foreach (var file in Directory.GetFiles(dir, $"*{ext}"))
                    {
                        var info = new FileInfo(file);
                        yield return new GameEntry
                        {
                            Name      = Path.GetFileNameWithoutExtension(file),
                            FilePath  = file,
                            Extension = ext,
                            SizeBytes = info.Length
                        };
                    }
                }
            }
        }
    }
}
