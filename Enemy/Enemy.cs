using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    abstract class Enemy    : IEnemy
    {
        protected ISprite sprite;

        public int X
        {
            get { return sprite.Position.X; }
            set
            {
                sprite.Position = new Point(value, sprite.Position.Y);
            }
        }

        public int Y
        {
            get { return sprite.Position.Y; }
            set
            {
                sprite.Position = new Point(sprite.Position.X, value);
            }
        }

        public int currentStep { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int changeDirection { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int xPos { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int yPos { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        
        public int xVel
        {
            get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException();
        }
        public int yVel
        {
            get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException();
        }
        public void BeStill()
        {
            throw new System.NotImplementedException();
        }

        public virtual void Draw(SpriteBatch sb)
        {
            sprite.Draw(sb);
        }

        public void MoveDown()
        {
            throw new System.NotImplementedException();
        }

        public void MoveLeft()
        {
            throw new System.NotImplementedException();
        }

        public void MoveRight()
        {
            throw new System.NotImplementedException();
        }

        public void MoveUp()
        {
            throw new System.NotImplementedException();
        }

        public virtual void Update()
        {
            sprite.Update();
        }

        public abstract void Use(IEnemy enemy);

        public void UseProjectile(IProjectile projectile)
        {
            throw new System.NotImplementedException();
        }
    }
}
