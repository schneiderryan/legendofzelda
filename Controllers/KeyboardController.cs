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
            foreach (Keys k in keys)
            {
                ICommand a;
                if (keyBinds.TryGetValue(k, out a))
                {
                    a.Execute();
                }
            }
        }
    }
}
