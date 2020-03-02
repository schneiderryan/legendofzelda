using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class BombPlaced : Projectile
    {
        public enum Bomb { Thrown, Returning, Pocket };
        public Bomb State { get; private set; }

        private ICollideable source;
        private int finalPositionX;
        private int finalPositionY;
        private Point finalPosition;

        public BombPlaced(string direction, ICollideable source, int initialVel = 6)
            : base(direction, source.X, source.Y, initialVel)
        {
            sprite = ProjectileSpriteFactory.Instance.CreateBoomerang();
            sprite.Position = new Point(X, Y);
            finalPositionX = X;
            finalPositionY = Y;
            Hitbox = sprite.Box;
            this.source = source;
            State = BoomerangState.Thrown;

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
            if (State == BoomerangState.Thrown)
            {
                if (sprite.Position.X == finalPosition.X && finalPosition.Y == sprite.Position.Y)
                {
                    State = BoomerangState.Returning;
                }
            }
            else if (State == BoomerangState.Returning)
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
