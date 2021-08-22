using System;
using System.Collections.Generic;
using System.Linq;

namespace QuakeRemakeKeybinder.Models
{
    public class WeaponKeybinds
    {
        public string Axe { get; set; }
        public string Shotgun { get; set; }
        public string SuperShotgun { get; set; }
        public string Nailgun { get; set; }
        public string SuperNailgun { get; set; }
        public string GrenadeLauncher { get; set; }
        public string RocketLauncher { get; set; }
        public string LightningGun { get; set; }
        public IEnumerable<Tuple<string, string>> WeaponBindPair
        {
            get
            {
                yield return new("impulse 1", Axe);
                yield return new("impulse 2", Shotgun);
                yield return new("impulse 3", SuperShotgun);
                yield return new("impulse 4", Nailgun);
                yield return new("impulse 5", SuperNailgun);
                yield return new("impulse 6", GrenadeLauncher);
                yield return new("impulse 7", RocketLauncher);
                yield return new("impulse 8", LightningGun);
            }
        }

        public WeaponKeybinds()
        {

        }

        public bool HaveAnyModifications()
        {
            return WeaponBindPair.Any(bind => !string.IsNullOrWhiteSpace(bind.Item2));
        }
    }
}
