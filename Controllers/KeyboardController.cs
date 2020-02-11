using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace LegendOfZelda
{
    public class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> keyBinds;

        public KeyboardController(Dictionary<Keys, ICommand> keyBinds)
        {
            this.keyBinds = keyBinds;
        }

        public void Update()
        {
            Keys[] keys = Keyboard.GetState().GetPressedKeys();
            ICommand a;
            foreach (Keys k in keys)
            {
                if (keyBinds.TryGetValue(k, out a))
                {
                    a.Execute();
                }
            }
            if (keys.Length == 0)
            {
                if (keyBinds.TryGetValue(Keys.None, out a))
                {
                    a.Execute();
                }
            }
        }
    }
}
