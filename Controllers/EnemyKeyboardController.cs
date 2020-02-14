using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace LegendOfZelda
{
    public class EnemyKeyboardController : IController
    {
        private Dictionary<Keys, ICommand> keyBinds;
        private LegendOfZelda game;
        private int speed;
        private int index;

        public EnemyKeyboardController(LegendOfZelda game1, Dictionary<Keys, ICommand> keyBinds)
        {
            this.keyBinds = keyBinds;
            this.game = game1;
            this.speed = 0;
            this.index = 0;
        }

        public void Update()
        {
            speed++;
            if (speed % 5 == 0)
            {
                Keys[] keys = Keyboard.GetState().GetPressedKeys();
                foreach (Keys k in keys)
                {
                    ICommand a;

                    if (keyBinds.TryGetValue(k, out a))
                    {
                        if (Keyboard.GetState().IsKeyDown(Keys.O))
                        {
                            if (index == 0)
                            {
                                index = game.enemies.Count;
                            }
                            else
                            {
                                index--;
                            }
                        }
                        else if (k == Keys.P)
                        {
                            if (index == game.enemies.Count)
                            {
                                index = 0;
                            }
                            else
                            {
                                index++;
                            }
                        }
                        a.Execute();
                    }

                }
            }
        }
    }
}