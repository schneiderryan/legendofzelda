using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    class HUDHearts
    {
        private LegendOfZelda game;
        private Texture2D itemSheet = Textures.GetItemSheet();
        private ISprite suddenDeathMessage;
        private int numFullHearts;
        private int numHalfHearts;
        private int numEmptyHearts;
        private int sheetX;
        private int sheetY;
        private int finalX;
        private int initX;
        private int initY;
        private int currentX;
        private int currentY;
        private int currentInt;
        private int fullX;
        private int fullY;
        private int halfX;
        private int halfY;
        private int emptyX;
        private int emptyY;
        private int offset;



        public HUDHearts(LegendOfZelda game)
        {
            this.game = game;
            numFullHearts = 0;
            numHalfHearts = 0;
            numEmptyHearts = 0;
            sheetX = 0;
            sheetY = 0;
            finalX = 476;
            initX = 372;
            initY = 80;
            currentX = 372;
            currentY = 80;
            currentInt = 0;
            fullX = 0;
            fullY = 34;
            halfX = 8;
            halfY = 0;
            emptyX = 16;
            emptyY = 0;
            suddenDeathMessage = FontSpriteFactory.GetSuddenDeathMessage();
        }

        public void Update()
        {
            if (game.link != null)
            {
                numFullHearts = (int)game.link.CurrentHearts;
                numHalfHearts = (int)(game.link.CurrentHearts * 2) % 2;
                numEmptyHearts = (int)game.link.MaxHearts - (numFullHearts + numHalfHearts);
            }
            suddenDeathMessage.X = initX;
            suddenDeathMessage.Y = initY + offset - 20;
            this.offset = game.hud.offset;
        }

        public void Draw()
        {

            if (!game.currentMode.Equals("sudden death"))
            {
                currentInt = 0;
                currentX = initX;
                currentY = offset + initY;
                while (currentInt < (numEmptyHearts + numFullHearts + numHalfHearts))
                {
                    if (currentInt < numFullHearts)
                    {
                        sheetX = fullX;
                        sheetY = fullY;
                    }
                    else if (currentInt < numFullHearts + numHalfHearts)
                    {
                        sheetX = halfX;
                        sheetY = halfY;
                    }
                    else
                    {
                        sheetX = emptyX;
                        sheetY = emptyY;
                    }
                    game.spriteBatch.Draw(itemSheet, new Rectangle(currentX, currentY, 13, 12), new Rectangle(sheetX, sheetY, 8, 8), Color.White);
                    currentX += 13;
                    if (currentX > finalX)
                    {
                        currentX = initX;
                        currentY -= 12;
                    }
                    currentInt++;
                }
            } else
            {
                suddenDeathMessage.Draw(game.spriteBatch);
            }
        }
    }
}
