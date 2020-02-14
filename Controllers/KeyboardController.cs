using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace LegendOfZelda
{
    public class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> keyBinds;
        private List<Keys> heldKeys;

        public KeyboardController(Dictionary<Keys, ICommand> keyBinds)
        {
            this.keyBinds = keyBinds;
            this.heldKeys = new List<Keys>();
        }

        public void Update()
        {
            KeyboardState state = Keyboard.GetState();
            Keys[] keys = state.GetPressedKeys();
            ICommand a;

            foreach (Keys k in keys)
            {
                if (!heldKeys.Contains(k) && keyBinds.TryGetValue(k, out a))
                {
                    a.Execute();
                    heldKeys.Add(k);
                }
            }

            if (keys.Length == 0 && keyBinds.TryGetValue(Keys.None, out a))
            {
                a.Execute();
            }

            UpdateHeldKeys(state);
        }

        private void UpdateHeldKeys(KeyboardState state)
        {
            for (int i = 0; i < heldKeys.Count; i++)
            {
                if (state.IsKeyUp(heldKeys[i]))
                {
                    heldKeys.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}