using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{

    class BoomerangProjectile :  Projectile
    {
        public enum BoomerangState { thrown, returning, pocket};
        public BoomerangState State { get; private set; }

        protected ICollideable source;
        private int finalPositionX;
        private int finalPositionY;
        private Point finalPosition;

        public BoomerangProjectile(string direction, ICollideable source, int initialVel = 6)
            : base(direction, source.X, source.Y, initialVel)
        {
            this.sprite = ProjectileSpriteFactory.Instance.CreateBoomerang();
            finalPositionX = X;
            finalPositionY = Y;
            Hitbox = sprite.Box;
            this.source = source;

            if (direction == "up")
            {
                finalPosition = new Point(finalPositionX, finalPositionY -= 144);
            }
            else if (direction == "down")
            {
                finalPosition = new Point(finalPositionX, finalPositionY += 144);
            }
            else if (direction == "right")
            {
                finalPosition = new Point(finalPositionX += 144, finalPositionY);
            }
            else if (direction == "left")
            {
                finalPosition = new Point(finalPositionX -= 144, finalPositionY);
            }
        }

        public override void Update()
        {
            if (State == BoomerangState.thrown)
            {
                if (sprite.Position.X == finalPosition.X && finalPosition.Y == sprite.Position.Y)
                {
                    State = BoomerangState.returning;
                }
            }
            else if (State == BoomerangState.returning)
            {
                int LinksXPos = this.source.X + 5;
                int LinksYPos = this.source.Y + 5;
                this.VX = (LinksXPos - X) / 20;
                this.VY = (LinksYPos - Y) / 20;
            }

            base.Update();
        }
    }
}
