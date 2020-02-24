﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    class Projectile : IProjectile
    {
        public int VX { get; set; }
        public int VY { get; set; }
        protected ISprite sprite;

        public Rectangle Hitbox { get; }

        public Projectile(string direction, int xPos, int yPos,
            int initialVel = 8)
        {
            VX = 0;
            VY = 0;
            X = xPos;
            Y = yPos;

            if (direction == "up")
            {
                this.VY = -initialVel;
            }
            else if (direction == "down")
            {
                this.VY = initialVel;
            }
            else if (direction == "right")
            {
                this.VX = initialVel;
            }
            else if (direction == "left")
            {
                this.VX = -initialVel;
            }
        }

        public virtual int X { get; set; }
        public virtual int Y { get; set; }

        public virtual void Update()
        {
            X += VX;
            Y += VY;
            sprite.Position = new Point(X, Y);
            sprite.Update();
        }

        public virtual void Draw(SpriteBatch sb)
        {
            sprite.Draw(sb, Color.White);
        }
    }
}
