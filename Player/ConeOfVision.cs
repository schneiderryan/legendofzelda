using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class ConeOfVision
    {
        private IPlayer player;
        private int x;
        private int y;
        private ISprite sprite;
        private Vector2 origin;
        public ConeOfVision(IPlayer player)
        {
            this.player = player;
            this.x = player.X;
            this.y = player.Y;
            this.sprite = MiscSpriteFactory.Instance.CreateConeOfVision();
            this.sprite.Scale = 5;
            this.origin = new Vector2(616, 492);
        }

        public void Update()
        {
            this.x = player.X;
            this.y = player.Y;
        }

        public void Draw(SpriteBatch sb)
        {
            this.sprite.Draw(sb, Color.White, origin);
        }

    }
}
