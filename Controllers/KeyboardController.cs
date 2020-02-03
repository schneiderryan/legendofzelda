using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Sprint0
{
    public class KeyboardController : IController
    {
        private Dictionary<Keys, IPlayerCommand> keyBinds;

        public KeyboardController(Dictionary<Keys, IPlayerCommand> keyBinds)
        {
            this.keyBinds = keyBinds;
        }

        public void Update()
        {
            Keys[] keys = Keyboard.GetState().GetPressedKeys();
            foreach (Keys k in keys)
            {
                IPlayerCommand a;
                if (keyBinds.TryGetValue(k, out a))
                {
                    a.Execute();
                }
            }
        }
    }
}
