using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace LegendOfZelda
{
    class EnemyKeyboardController : IController
    {
        private Dictionary<Keys, ICommand> keyBinds;
        private LegendOfZelda game;
        private int speed;

        public EnemyKeyboardController(LegendOfZelda game, Dictionary<Keys, ICommand> keyBinds)
        {
            this.keyBinds = keyBinds;
            this.game = game;
            this.speed = 0;
        }

        public void Update()
        {
            /*speed++;
            if (speed % 5 == 0)
            {
                Keys[] keys = Keyboard.GetState().GetPressedKeys();
                foreach (Keys k in keys)
                {
                    ICommand a;

                    if (Keyboard.GetState().IsKeyDown(Keys.O))
                    {
                        if (game.enemyIndex == 0)
                        {
                            game.enemyIndex = game.enemies.Count - 1;
                        }
                        else
                        {
                            game.enemyIndex--;
                        }
                    }
                    else if (k == Keys.P)
                    {
                        if (game.enemyIndex == game.enemies.Count - 1)
                        {
                            game.enemyIndex = 0;
                        }
                        else
                        {
                            game.enemyIndex++;
                        }
                    }

                    if (keyBinds.TryGetValue(k, out a))
                    {
                        a.Execute();
                    }

                }
            }*/
        }
    }
}