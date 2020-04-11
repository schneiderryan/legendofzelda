using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class PauseMessage
    {
        private LegendOfZelda game;
        private int xCoord;
        private int yCoord;
        private ISprite char1;
        private ISprite char2;
        private ISprite char3;
        private ISprite char4;
        private ISprite char5;
        private ISprite char6;
        public PauseMessage(LegendOfZelda game)
        {
            this.game = game;
            xCoord = 215;
            yCoord = 290;
        }

        public void Update()
        {
            //do nothing
        }

        public void Draw()
        {
            char1 = FontSpriteFactory.GetP();
            char2 = FontSpriteFactory.GetA();
            char3 = FontSpriteFactory.GetU();
            char4 = FontSpriteFactory.GetS();
            char5 = FontSpriteFactory.GetE();
            char6 = FontSpriteFactory.GetD();
            char1.X = xCoord;
            char2.X = xCoord + 16;
            char3.X = xCoord + 32;
            char4.X = xCoord + 48;
            char5.X = xCoord + 64;
            char6.X = xCoord + 80;
            char1.Y = char2.Y = char3.Y = char4.Y = char5.Y = char6.Y = yCoord;
            char1.Draw(game.spriteBatch);
            char2.Draw(game.spriteBatch);
            char3.Draw(game.spriteBatch);
            char4.Draw(game.spriteBatch);
            char5.Draw(game.spriteBatch);
            char6.Draw(game.spriteBatch);
        }
    }
}
