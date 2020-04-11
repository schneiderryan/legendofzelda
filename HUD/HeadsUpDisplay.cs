using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class HeadsUpDisplay
    {
        private LegendOfZelda game;
        private Texture2D itemSheet = Textures.GetItemSheet();
        private int numFullHearts;
        private int numHalfHearts;
        private int numEmptyHearts;
        private double currentHearts;
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
        private IItem currentItem;



        public HeadsUpDisplay(LegendOfZelda game)
        {
            this.game = game;
            numFullHearts = 0;
            numHalfHearts = 0;
            numEmptyHearts = 0;
            currentHearts = 0;
            sheetX = 0;
            sheetY = 0;
            finalX = 468;
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
     }
        
        public void Update()
        {
            //notihng yet

            if (game.link != null)
            {
                
                numFullHearts = 0;
                numHalfHearts = 0;
                numEmptyHearts = 0;
                currentHearts = 0;
                currentHearts = game.link.CurrentHearts;
                while (currentHearts >= 0.1)
                {
                    if (currentHearts - 1.0 >= 0.00)
                    {
                        currentHearts = currentHearts - 1.0;
                        numFullHearts++;
                    }
                    else if (currentHearts - 0.5 >= 0.00)
                    {
                        currentHearts = currentHearts - 0.5;
                        numHalfHearts++;
                    }
                }
                numEmptyHearts = (int)game.link.MaxHearts - (numFullHearts + numHalfHearts);
            }
        }

        public void Draw()
        {
            currentInt = 0;
            currentX = initX;
            currentY = initY;
            while (currentInt < (numEmptyHearts + numFullHearts + numHalfHearts)) {
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
                game.spriteBatch.Draw(itemSheet, new Rectangle(currentX, currentY, 12, 12), new Rectangle(sheetX, sheetY, 8, 8), Color.White);
                currentX += 12;
                if (currentX > finalX)
                {
                    currentX = initX;
                    currentY -= 12;
                }
                currentInt++;
                game.spriteBatch.Draw(itemSheet, new Rectangle(305, 55, 14, 32), new Rectangle(104, 0, 7, 16), Color.White);
            }
            
        }
    }
}
