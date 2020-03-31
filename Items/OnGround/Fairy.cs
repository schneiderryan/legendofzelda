using System;
using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class Fairy : Item, IMovingItem
    {
        private int ticks = 0;
        private readonly Random rng;

        private double vx = 0;
        private double vy = 0;
        private double x = 0;
        private double y = 0;
        private const int MAX_V = 1;

        public override int X
        {
            get => (int)x;
            set {
                base.X = value;
                x = value;
            }
        }

        public override int Y
        {
            get => (int)y;
            set
            {
                base.Y = value;
                y = value;
            }
        }

        public Fairy()
        {
            sprite = ItemSpriteFactory.GetFairy();
            Hitbox = sprite.Box;
            rng = new Random();
            NewTrajectory();
        }

        public override void Collect(IPlayer player)
        {
            player.CurrentHearts = player.MaxHearts;
        }

        public override void Update()
        {
            ticks -= 1;
            x += vx;
            y += vy;
            Rectangle hitbox = Hitbox;
            hitbox.X = (int)x;
            hitbox.Y = (int)y;
            Hitbox = hitbox;

            if (ticks <= 0)
            {
                NewTrajectory();
            }
            base.Update();
        }

        public void FlipVY()
        {
            vy = -vy;
        }

        public void FlipVX()
        {
            vx = -vx;
        }

        private void NewTrajectory()
        {
            ticks = rng.Next(30, 120);
            vx = (rng.NextDouble() * 2 * MAX_V) - MAX_V;
            vy = Math.Sqrt(MAX_V * MAX_V - vx * vx);
            if (rng.Next(0, 2) == 0)
            {
                vy = -vy;
            }
        }
    }
}
