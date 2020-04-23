using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace LegendOfZelda
{
    class SinglePressKeyboardController : IController
    {
        private IDictionary<Keys, ICommand> keyBinds;
        private IDictionary<Keys, int> heldKeys;
        private const int COOLDOWN = 20;
        private IPlayer player;

        public SinglePressKeyboardController(IDictionary<Keys, ICommand> keyBinds, IPlayer player)
        {
            this.keyBinds = keyBinds;
            this.heldKeys = new Dictionary<Keys, int>();
            this.player = player;
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
                    heldKeys.Add(k, COOLDOWN);
                }
            }
            UpdateHeldKeys(state);

            if (keys.Length == 0 && keyBinds.TryGetValue(Keys.None, out a))
            {
                a.Execute();
            }
        }

        private void UpdateHeldKeys(KeyboardState state)
        {
            // copy Keys into a list so we can modify the dictionary while iterating
            List<Keys> keys = new List<Keys>(heldKeys.Keys);
            if(keys.Contains(Keys.F) && keys.Contains(Keys.G) && keys.Contains(Keys.H))
            {
                ICommand cmd = new AddRupeesCommand(player);
                cmd.Execute();
            }
            for (int i = 0; i < keys.Count; i++)
            {
                if (state.IsKeyUp(keys[i]) && heldKeys[keys[i]] <= 0)
                {
                    heldKeys.Remove(keys[i]);
                }
                else if (heldKeys[keys[i]] > 0)
                {
                    heldKeys[keys[i]]--;
                }
            }
        }
    }
}
