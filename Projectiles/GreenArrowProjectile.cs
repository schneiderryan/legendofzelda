﻿using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class GreenArrowProjectile : Projectile
    {
        public GreenArrowProjectile(string direction, ICollideable source)
            : base(direction, source)
        {
            if (direction == "up")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateUpArrow();
            }
            else if (direction == "down")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateDownArrow();
            }
            else if (direction == "right")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateRightArrow();
            }
            else // left
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateLeftArrow();
            }
            sprite.Position = new Point(X, Y);
            Hitbox = sprite.Box;
        }
    }
}
