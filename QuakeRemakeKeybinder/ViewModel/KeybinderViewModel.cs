using QuakeRemakeKeybinder.Commands;
using QuakeRemakeKeybinder.Models;
using QuakeRemakeKeybinder.Services;
using System;
using System.IO;

namespace QuakeRemakeKeybinder.ViewModel
{
    public class KeybinderViewModel : BaseViewModel
    {
        private string ConfigFolderPath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Nightdive Studios", "Quake");
        private bool ConfigPathExists => Directory.Exists(ConfigFolderPath);

        public string AxeKeybind { get; set; }
        public string ShotgunKeybind { get; set; }
        public string SuperShotgunKeybind { get; set; }
        public string NailgunKeybind { get; set; }
        public string SuperNailgunKeybind { get; set; }
        public string GrenadeLauncherKeybind { get; set; }
        public string RocketLauncherKeybind { get; set; }
        public string LightningGunKeybind { get; set; }
        public DelegateCommand GenerateConfigCommand { get; set; }

        public KeybinderViewModel()
        {
            GenerateConfigCommand = new DelegateCommand(GenerateConfig);
        }

        public void GenerateConfig()
        {
            var keybinds = new WeaponKeybinds
            {
                Axe = AxeKeybind,
                Shotgun = ShotgunKeybind,
                SuperShotgun = SuperShotgunKeybind,
                Nailgun = NailgunKeybind,
                SuperNailgun = SuperNailgunKeybind,
                GrenadeLauncher = GrenadeLauncherKeybind,
                RocketLauncher = RocketLauncherKeybind,
                LightningGun = LightningGunKeybind
            };

            var configWriter = new ConfigWriter(keybinds);

            if (ConfigPathExists)
            {
                configWriter.ConfigFilePath = ConfigFolderPath;
                configWriter.Write();
            }
            else
            {
                Directory.CreateDirectory(ConfigFolderPath);
                configWriter.Write();
            }
        }
    }
}
