using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace LegendOfZelda
{
    class SlowKeyboardController : IController
    {
        private Dictionary<Keys, ICommand> keyBinds;
        private Dictionary<Keys, int> heldKeys;
        private const int TIMEOUT = 60;

        public SlowKeyboardController(Dictionary<Keys, ICommand> keyBinds)
        {
            this.keyBinds = keyBinds;
            this.heldKeys = new Dictionary<Keys, int>();
        }

        public void Update()
        {
            KeyboardState state = Keyboard.GetState();
            Keys[] keys = state.GetPressedKeys();
            ICommand a;

            foreach (Keys k in keys)
            {
                if (!heldKeys.ContainsKey(k) && keyBinds.TryGetValue(k, out a))
                {
                    a.Execute();
                    heldKeys.Add(k, TIMEOUT);
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
            // copy Keys into a list so we can modify the dictionary while iterating
            List<Keys> keys = new List<Keys>(heldKeys.Keys);
            for (int i = 0; i < keys.Count; i++)
            {
                if (state.IsKeyUp(keys[i]) || heldKeys[keys[i]] == 0)
                {
                    heldKeys.Remove(keys[i]);
                }
                else if (heldKeys.ContainsKey(keys[i]))
                {
                    heldKeys[keys[i]]--;
                }
            }
        }
    }
}
