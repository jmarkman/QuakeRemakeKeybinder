using QuakeRemakeKeybinder.Models;
using System;
using System.IO;

namespace QuakeRemakeKeybinder.Services
{
    public class ConfigWriter
    {
        private readonly string configFileName = "autoexec.cfg";
        private readonly WeaponKeybinds keybinds;

        public string ConfigFilePath { get; set; }
        private string FullConfigFilePath => Path.Join(ConfigFilePath, configFileName);

        public ConfigWriter(WeaponKeybinds keybinds)
        {
            this.keybinds = keybinds;
        }

        public void Write()
        {
            if (!File.Exists(FullConfigFilePath))
            {
                File.Create(FullConfigFilePath).Dispose();
            }

            using StreamWriter textWriter = new(FullConfigFilePath);

            if (keybinds.HaveAnyModifications())
            {
                foreach (Tuple<string, string> bind in keybinds.WeaponBindPair)
                {
                    textWriter.WriteLine($"bind {bind.Item2} \"{bind.Item1}\"");
                }
            }
        }

        
    }
}
