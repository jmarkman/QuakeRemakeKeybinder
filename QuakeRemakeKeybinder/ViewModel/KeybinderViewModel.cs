using QuakeRemakeKeybinder.Commands;
using QuakeRemakeKeybinder.Models;
using QuakeRemakeKeybinder.Services;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows;

namespace QuakeRemakeKeybinder.ViewModel
{
    public class KeybinderViewModel : BaseViewModel
    {
        private string ConfigFolderPath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Saved Games", "Nightdive Studios", "Quake");
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
        public DelegateCommand ClearInputsFromUICommand { get; set; }

        public KeybinderViewModel()
        {
            GenerateConfigCommand = new DelegateCommand(GenerateConfig);
            ClearInputsFromUICommand = new DelegateCommand(ClearInputsFromUI);
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
                _ = Directory.CreateDirectory(ConfigFolderPath);
                configWriter.Write();
            }

            _ = MessageBox.Show("Autoexec with weapon binds created!", "Success");
            _ = Process.Start("explorer.exe", $"/select, {Path.Join(ConfigFolderPath, "autoexec.cfg")}");
            ClearInputsFromUI();
        }

        public void ClearInputsFromUI()
        {
            AxeKeybind = string.Empty;
            ShotgunKeybind = string.Empty;
            SuperShotgunKeybind = string.Empty;
            NailgunKeybind = string.Empty;
            SuperNailgunKeybind = string.Empty;
            GrenadeLauncherKeybind = string.Empty;
            RocketLauncherKeybind = string.Empty;
            LightningGunKeybind = string.Empty;
        }
    }
}
