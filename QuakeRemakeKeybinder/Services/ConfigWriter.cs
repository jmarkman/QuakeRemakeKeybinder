using QuakeRemakeKeybinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuakeRemakeKeybinder.Services
{
    public class ConfigWriter
    {
        private UserSpecifiedKeybinds keybinds;

        public ConfigWriter(UserSpecifiedKeybinds keybinds)
        {
            this.keybinds = keybinds;
        }

        public void Write()
        {

        }
    }
}
