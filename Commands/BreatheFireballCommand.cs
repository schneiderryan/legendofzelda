using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public class BreatheFireballCommand : ICommand
    {
        private LegendOfZelda game;

        public BreatheFireballCommand(LegendOfZelda game)
        {
            this.game = game;
        }

        public void Execute()
        {
            if (game.enemies[game.enemyIndex] is Aquamentus)
            {
                Aquamentus aq = game.enemies[game.enemyIndex] as Aquamentus;
                aq.BreatheFireball(aq.xPos, aq.yPos);
            }
        }
    }
}