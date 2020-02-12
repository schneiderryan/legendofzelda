using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace LegendOfZelda
{
    public class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> keyBinds;
        private LegendOfZelda game;
        private int speed;

        public KeyboardController(LegendOfZelda game1, Dictionary<Keys, ICommand> keyBinds)
        {
            this.keyBinds = keyBinds;
            this.game = game1;
            this.speed = 0;
        }

        public void Update()
        {
            speed++;
            if(speed % 5 == 0)
            {
                Keys[] keys = Keyboard.GetState().GetPressedKeys();
                foreach (Keys k in keys)
                {
                    ICommand a;

                    if (keyBinds.TryGetValue(k, out a))
                    {
                        if (Keyboard.GetState().IsKeyDown(Keys.O))
                        {
                            if (game.index == 0)
                            {
                                game.index = game.maxEnemy;
                            }
                            else
                            {
                                game.index--;
                            }

                        }
                        else if (k == Keys.P)
                        {
                            if (game.index == game.maxEnemy)
                            {
                                game.index = 0;
                            }
                            else
                            {
                                game.index++;
                            }

                        }
                        game.enemy = game.list[game.index];
                        a.Execute();
                    }
            
                }
            }
        }
    }
}
