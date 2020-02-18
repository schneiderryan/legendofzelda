using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class EnemyProjectile : IProjectile
    {
        protected int xVel = 0;
        protected int yVel = 0;
        protected ISprite sprite;

        public EnemyProjectile(ISprite sprite, Vector2 position, Vector2 velocity)
        {
            this.sprite = sprite;
            X = (int)position.X;
            Y = (int)position.Y;
            this.xVel = (int)velocity.X;
            this.yVel = (int)velocity.Y;
        }

        public virtual int X { get; protected set; }
        public virtual int Y { get; protected set; }

        public virtual void Update()
        {
            X += xVel;
            Y += yVel;
            sprite.Position = new Point(X, Y);
            sprite.Update();
        }

        public virtual void Draw(SpriteBatch sb)
        {
            sprite.Draw(sb, Color.White);
        }
    }
}
