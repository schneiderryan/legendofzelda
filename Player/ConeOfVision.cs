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
        private const int xOffset = 22;
        private const int yOffset = 20;
        private int y;
        private ISprite sprite;
        private Texture2D cone;
        private Vector2 origin;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public ConeOfVision(IPlayer player)
        {
            this.player = player;
            this.x = player.X + xOffset;
            this.y = player.Y + yOffset;
            this.sprite = MiscSpriteFactory.Instance.CreateConeOfVision();
            this.sprite.Scale = 4f;
            this.sprite.Position = new Point(x, y);
            this.cone = Textures.GetConeOfVision();
            this.origin = new Vector2(616, 492);
            //this.origin = new Vector2(1232, 984);
        }

        public void Update()
        {
            this.x = player.X + xOffset;
            this.y = player.Y + yOffset;
            this.sprite.Position = new Point(x, y);
        }

        public void Draw(SpriteBatch sb)
        {
            this.sprite.Draw(sb, Color.White, origin);
            //sb.Draw(cone, new Rectangle(0, 120, sb.GraphicsDevice.Viewport.Width - 100, sb.GraphicsDevice.Viewport.Height-120), new Rectangle(0, 0, cone.Width, cone.Height), Color.White);
        }

    }
}
