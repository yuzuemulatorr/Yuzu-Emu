using System;
using System.IO;
using System.Text.RegularExpressions;

namespace YuzuLauncher
{
    public static class KeysValidator
    {
        private static readonly string KEYS_PATH = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "yuzu", "keys", "prod.keys");

        public static bool ProdKeysExist() => File.Exists(KEYS_PATH);

        public static string GetKeysPath() => KEYS_PATH;

        public static bool ValidateFormat()
        {
            if (!ProdKeysExist()) return false;
            var content = File.ReadAllText(KEYS_PATH);
            // prod.keys must contain at least a master_key_00 entry
            return Regex.IsMatch(content, @"master_key_\d{2}\s*=\s*[0-9a-fA-F]{32}");
        }

        public static string DetectMissingKeys()
        {
            if (!ProdKeysExist())
                return $"prod.keys not found at {KEYS_PATH}.\nDump from your Switch using Lockpick_RCM.";
            if (!ValidateFormat())
                return "prod.keys exists but appears to be in an invalid format. Re-dump from your console.";
            return null; // null = OK
        }
    }
}
