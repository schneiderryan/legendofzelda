using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class SwordProjectile : IProjectile
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
            get { return (int)yPos; }
        }

        public SwordProjectile(String direction, int xPos, int yPos, int velocity)
        {
            if (direction == "up")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateUpSwordProjectile();
                this.xVel = 0;
                this.yVel = -velocity;
            }
            else if (direction == "down")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateDownSwordProjectile();
                this.xVel = 0;
                this.yVel = velocity;
            }
            else if (direction == "right")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateRightSwordProjectile();
                this.xVel = velocity;
                this.yVel = 0;
            }
            else if (direction == "left")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateLeftSwordProjectile();
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
