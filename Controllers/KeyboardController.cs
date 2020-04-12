using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace LegendOfZelda
{
    class KeyboardController : IController
    {
        public enum Priority { NORMAL, HIGH }

        private IDictionary<Keys, (ICommand, Priority)> keyBinds;

        public KeyboardController()
        {
            this.keyBinds = new Dictionary<Keys, (ICommand, Priority)>();
        }

        public void Register(Keys key, ICommand cmd, Priority priority = Priority.NORMAL)
        {
            keyBinds.Add(key, (cmd, priority));
        }

        public void Update()
        {
            KeyboardState state = Keyboard.GetState();
            Keys[] keys = state.GetPressedKeys();
            LinkedList<ICommand> priorityList = new LinkedList<ICommand>();
            (ICommand, Priority) a;

            foreach (Keys k in keys)
            {
                if (keyBinds.TryGetValue(k, out a))
                {
                    if (a.Item2 == Priority.HIGH)
                    {
                        priorityList.AddFirst(a.Item1);
                    }
                    else
                    {
                        priorityList.AddLast(a.Item1);
                    }
                }
            }

            if (priorityList.Count > 0)
            {
                priorityList.First.Value.Execute();
            }

            if (keys.Length == 0 && keyBinds.TryGetValue(Keys.None, out a))
            {
                a.Item1.Execute();
            }
        }
    }
}
