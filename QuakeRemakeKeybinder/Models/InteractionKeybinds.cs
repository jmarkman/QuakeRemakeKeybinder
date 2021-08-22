using System.Collections.Generic;
using System.Linq;

namespace QuakeRemakeKeybinder.Models
{
    public class InteractionKeybinds
    {
        public string MoveForward { get; set; }
        public string MoveBackward { get; set; }
        public string MoveLeft { get; set; }
        public string MoveRight { get; set; }
        public string WalkRunToggle { get; set; }
        public string Jump { get; set; }
        public string Fire { get; set; }

        private IEnumerable<string> Keybinds
        {
            get
            {
                yield return MoveForward;
                yield return MoveBackward;
                yield return MoveLeft;
                yield return MoveRight;
                yield return WalkRunToggle;
                yield return Jump;
                yield return Fire;
            }
        }

        public InteractionKeybinds()
        {

        }

        public bool HaveAnyModifications()
        {
            return Keybinds.Any(bind => !string.IsNullOrWhiteSpace(bind));
        }
    }
}
