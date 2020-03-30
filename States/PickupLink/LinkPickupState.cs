using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    internal class LinkPickupState : ILinkState
    {
        private GreenLink link;
        private int delay;
        private int time;

        public LinkPickupState(GreenLink link, int time)
        {
            this.link = link;
            delay = 0;
            this.time = time;
        }

        public void MoveUp()
        {
            //Nothing to do
        }

        public void MoveDown()
        {
            //Nothing to do
        }

        public void MoveRight()
        {
            //Nothing to do
        }

        public void MoveLeft()
        {
            //Nothing to do
        }

        public void Attack()
        {
            //Nothing to do
        }

        public void BeStill()
        {
            //Nothing to do
        }

        public void PickupItem(int time)
        {
            //Nothing to do
        }

        public void Update()
        {
            if(delay > 5)
            {
                link.Sprite = PlayerSpriteFactory.Instance.CreateLinkPickup2();
            }
            if(delay == time)
            {
                link.State = new StillDownLinkState(link);
                link.Sprite = PlayerSpriteFactory.Instance.CreateDownStillLinkSprite();
                link.Sprite.Scale = 2.0f;
            }
            link.Sprite.Position = new Point(link.X, link.Y);
            delay++;
        }

        public void Projectile()
        {
            //Nothing to do
        }
    }
}