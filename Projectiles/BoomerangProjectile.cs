using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class BoomerangProjectile :  Projectile
    {
        public bool Returned { get => state == BoomerangState.Pocket; }

        private enum BoomerangState { Thrown, Returning, Pocket }
        private BoomerangState state = BoomerangState.Thrown;

        private int finalPositionX;
        private int finalPositionY;
        private Point finalPosition;

        public BoomerangProjectile(string direction, ICollideable source, int initialVel = 6)
            : base(direction, source, initialVel)
        {
            sprite = ProjectileSpriteFactory.Instance.CreateBoomerang();
            sprite.Position = new Point(X, Y);
            finalPositionX = X;
            finalPositionY = Y;
            Hitbox = sprite.Box;

            if (direction == "up")
            {
                finalPosition = new Point(finalPositionX, finalPositionY - 144);
            }
            else if (direction == "down")
            {
                finalPosition = new Point(finalPositionX, finalPositionY + 144);
            }
            else if (direction == "right")
            {
                finalPosition = new Point(finalPositionX + 144, finalPositionY);
            }
            else if (direction == "left")
            {
                finalPosition = new Point(finalPositionX - 144, finalPositionY);
            }
        }

        public override void Update()
        {
            if (state == BoomerangState.Thrown
                    && X == finalPosition.X && finalPosition.Y == Y)
            {
                Return();
            }
            else if (state == BoomerangState.Returning)
            {
                this.VX = (source.X - X) / 20;
                this.VY = (source.Y - Y) / 20;
                if (VX == 0 && VY == 0)
                {
                    state = BoomerangState.Pocket;
                }
            }

            base.Update();
        }

        public void Return()
        {
            state = BoomerangState.Returning;
        }

        public override IDespawnEffect GetDespawnEffect()
        {
            return new NoDespawnEffect();
        }

    }
}
