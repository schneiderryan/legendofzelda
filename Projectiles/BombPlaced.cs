using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class BombPlaced : Projectile
    {
        public override double Damage => 4;
        public enum BombState { Placed, Detonated, Exploding, Used };
        public BombState State { get; private set; }
        private int fuseDelay;
        private int timer;

        private ICollideable source;

        public BombPlaced(string direction, ICollideable source, int initialVel = 6)
            : base(direction, source.X, source.Y, initialVel)
        {
            sprite = ItemSpriteFactory.GetBomb();
            Hitbox = sprite.Box;
            this.source = source;
            State = BombState.Detonated;
            fuseDelay = 60;
            timer = 60;

            if (direction == "up")
            {
                this.Y -= 30;
            }
            else if (direction == "down")
            {
                this.Y += 30;
            }
            else if (direction == "right")
            {
                this.X += 30;
            }
            else if (direction == "left")
            {
                this.X -= 30;
            }
        }

        public override void Update()
        {
            if (State == BombState.Detonated)
            {
                if (fuseDelay > 0)
                {
                    sprite = ItemSpriteFactory.GetBomb();
                    sprite.Position = new Point(this.X, this.Y);
                    fuseDelay--;
                }
                else
                {
                    State = BombState.Exploding;
                    sprite = ItemSpriteFactory.GetExplodingBomb();
                    sprite.Position = new Point(this.X, this.Y);
                    Hitbox = sprite.Box;
                }
            }
            else if (State == BombState.Exploding)
            {
                if (timer > 0)
                {
                    timer--;
                } else
                {
                    State = BombState.Used;
                    
                }
            }
        }

    }
}
