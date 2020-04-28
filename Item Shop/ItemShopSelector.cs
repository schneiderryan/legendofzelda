﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class ItemShopSelector
    {
        private LegendOfZelda game;
        private ISprite selectorSprite;
        private int currentDelay;
        private int totalDelay;
        private int x = 60;
        private int normalY = 85;
        private int selectorOffset = 75 ;
        private int offsetMultiplier = 0;
        private HUDCounter hudrupees;
       
        

        private string[] items;
        public ItemShopSelector(LegendOfZelda game)
        {
            
            string[] items = {"sword", "heart", "bluepotion"};
            this.game = game;
            
            this.selectorSprite = MiscSpriteFactory.Instance.CreateItemShopSelector();
            hudrupees = new HUDCounter(this.game, "rupees");
            currentDelay = 0;
            totalDelay = 5;
            selectorSprite.X = x;
            selectorSprite.Y = normalY;
        }

        public void Update()
        {
            hudrupees.Update();
            currentDelay++;
            if (currentDelay == totalDelay)
            {
                selectorSprite.Update();
                currentDelay = 0;
            }

            if (game.currentShopItem.Equals("sword"))
            {
                offsetMultiplier = 0;
            } else if (game.currentShopItem.Equals("heart"))
            {
                offsetMultiplier = 1;
            } else if (game.currentShopItem.Equals("bluepotion"))
            {
                offsetMultiplier = 2;
            }
            selectorSprite.Y = normalY + offsetMultiplier*selectorOffset;
        }

        public void Draw()
        {
            
            hudrupees.Draw();
            selectorSprite.Draw(game.spriteBatch);
        }
    }
}
