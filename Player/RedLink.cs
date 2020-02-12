using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class RedLink : IPlayer 
    {
        public LegendOfZelda game;
        public ISprite sprite;
        public ILinkState state;
        public int xPos;
        public int yPos;
        private int item1Timer;

        public RedLink(LegendOfZelda game)
        {
            this.sprite = PlayerSpriteFactory.Instance.CreateRedUpStillLinkSprite();
            this.sprite.Scale = 2.0f;
            this.xPos = 400;
            this.yPos = 200;
            this.sprite.Position = new Point(xPos, yPos);
            this.state = new StillUpRedLinkState(this);
            this.game = game;
            this.item1Timer = 0;
        }

        public void MoveLeft()
        {
            state.MoveLeft();
        }

        public void MoveRight()
        {
            state.MoveRight();
        }
        
        public void MoveUp()
        {
            state.MoveUp();
        }

        public void MoveDown()
        {
            state.MoveDown();
        }

        public void Attack()
        {
            state.Attack();
        }

        public void BeStill()
        {
            state.BeStill();
        }

        public void Update()
        {
            state.Update();
            sprite.Update();
            if(item1Timer > 0)
            {
                item1Timer--;
            }
        }

        public void Draw(SpriteBatch sb, Color color)
        {
            sprite.Draw(sb, color);
        }

        public void UseItem(ProjectileItem item)
        {
            if (item1Timer == 0)
            {
                item1Timer = 75;
                state.UseItem(item);
            }
        }

        public void TakeDamage()
        {
            this.game.link = new DamagedLink(this, this.game);
        }
    }
}
