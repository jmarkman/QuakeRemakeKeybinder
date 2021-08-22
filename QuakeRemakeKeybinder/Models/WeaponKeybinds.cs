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

        private IEnumerable<string> Keybinds
        {
            get
            {
                yield return Axe;
                yield return Shotgun;
                yield return SuperShotgun;
                yield return Nailgun;
                yield return SuperNailgun;
                yield return GrenadeLauncher;
                yield return RocketLauncher;
                yield return LightningGun;
            }
        }

        public WeaponKeybinds()
        {

        }

        public bool HaveAnyModifications()
        {
            return Keybinds.Any(bind => !string.IsNullOrWhiteSpace(bind));
        }
    }
}
