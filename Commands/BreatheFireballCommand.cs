using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public class BreatheFireballCommand : ICommand
    {
        private LegendOfZelda game1;

        public BreatheFireballCommand(LegendOfZelda game1)
        {
            this.game1 = game1;
        }

        public void Execute()
        {
            ;
            game1.aquamentus.BreatheFireball(game1.aquamentus.xPos, game1.aquamentus.yPos);
        }
    }
}