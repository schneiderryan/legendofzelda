using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class ArrowProjectile : IProjectile
    {
        private int xPos;
        private int yPos;
        private int xVel;
        private int yVel;
        private ISprite sprite;

        public int X
        {
            get { return xPos; }
        }
        public int Y
        {
            get { return (int) yPos; }
        }

        public ArrowProjectile(String direction, String color, int xPos, int yPos, int velocity)
        {
            if(direction == "up")
            {
                if (color == "green")
                {
                    this.sprite = ProjectileSpriteFactory.Instance.CreateUpArrow();
                } else if(color == "red")
                {
                    this.sprite = ProjectileSpriteFactory.Instance.CreateRedUpArrow();
                }
                this.xVel = 0;
                this.yVel = -velocity;
            } 
            else if(direction == "down")
            {
                if (color == "green")
                {
                    this.sprite = ProjectileSpriteFactory.Instance.CreateDownArrow();
                }
                else if (color == "red")
                {
                    this.sprite = ProjectileSpriteFactory.Instance.CreateRedDownArrow();
                }
                this.xVel = 0;
                this.yVel = velocity;
            } 
            else if(direction == "right")
            {
                if (color == "green")
                {
                    this.sprite = ProjectileSpriteFactory.Instance.CreateRightArrow();
                }
                else if (color == "red")
                {
                    this.sprite = ProjectileSpriteFactory.Instance.CreateRedRightArrow();
                }
                this.xVel = velocity;
                this.yVel = 0;
            } 
            else if(direction == "left")
            {
                if (color == "green")
                {
                    this.sprite = ProjectileSpriteFactory.Instance.CreateLeftArrow();
                }
                else if (color == "red")
                {
                    this.sprite = ProjectileSpriteFactory.Instance.CreateRedLeftArrow();
                }
                this.xVel = -velocity;
                this.yVel = 0;
            }
            this.xPos = xPos;
            this.yPos = yPos;
            sprite.Position = new Point(xPos, yPos);
        }

        public virtual void Update()
        {
            xPos += xVel;
            yPos += yVel;
            sprite.Position = new Point(xPos, yPos);
            sprite.Update();
        }

        public virtual void Draw(SpriteBatch sb)
        {
            sprite.Draw(sb, Color.White);
        }

    }
}
