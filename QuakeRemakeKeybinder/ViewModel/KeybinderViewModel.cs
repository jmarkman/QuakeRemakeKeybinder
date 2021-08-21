﻿using QuakeRemakeKeybinder.Commands;
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
        public string MoveForwardKeybind { get; set; }
        public string MoveBackwardKeybind { get; set; }
        public string MoveLeftKeybind { get; set; }
        public string MoveRightKeybind { get; set; }
        public string WalkRunToggleKeybind { get; set; }
        public string FireWeaponKeybind { get; set; }
        public DelegateCommand GenerateConfigCommand { get; set; }

        public KeybinderViewModel()
        {
            GenerateConfigCommand = new DelegateCommand(GenerateConfig);
        }

        public void GenerateConfig()
        {
            if (ConfigPathExists)
            {
                // Generate config
            }
            else
            {
                Directory.CreateDirectory(ConfigFolderPath);
            }
        }
    }
}
