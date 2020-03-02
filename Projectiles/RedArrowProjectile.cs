﻿using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class RedArrowProjectile : Projectile
    {
        public RedArrowProjectile(string direction, int x, int y)
            : base(direction, x, y)
        {
            if(direction == "up")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateRedUpArrow();
            } 
            else if(direction == "down")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateRedDownArrow();
            } 
            else if(direction == "right")
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateRedRightArrow();
            } 
            else // left
            {
                this.sprite = ProjectileSpriteFactory.Instance.CreateRedLeftArrow();
            }
            sprite.Position = new Point(X, Y);
            Hitbox = sprite.Box;
        }
    }
}
