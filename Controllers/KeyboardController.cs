using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace LegendOfZelda
{
    public class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> keyBinds;
        private LegendOfZelda game;
        private int speed;

        public KeyboardController(LegendOfZelda game, Dictionary<Keys, ICommand> keyBinds)
        {
            this.speed = 0;
            this.game = game;
            this.keyBinds = keyBinds;

        }

        public void Update()
        {
            speed++;
            Keys[] keys = Keyboard.GetState().GetPressedKeys();
            ICommand a;
            foreach (Keys k in keys)
            {
                if (keyBinds.TryGetValue(k, out a))
                {
                    if (Keyboard.GetState().IsKeyDown(Keys.O))
                    {
                        if(speed % 10 == 0)
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
                        

                    }
                    else if (k == Keys.P)
                    {
                        if (speed % 10 == 0)
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
                    }
                    game.enemy = game.list[game.index];
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