using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{

    class BottomKey : IDoor
    {
        private Rectangle hitbox;
        public ISprite door;
        public Rectangle Hitbox
        {
            get { return hitbox; }
            protected set { hitbox = value; }
        }


        public BottomKey()
        {
            door = RoomSpriteFactory.Instance.CreateBottomKey();
            door.Scale = 2.0f;
            door.Position = new Point(224, 288);
            hitbox = new Rectangle( door.Position.X, door.Position.Y, 64, 64);
        }


        public void Draw(SpriteBatch sb, Color color)
        {
            door.Draw(sb);
        }
        public void Update()
        {
            door.Update();
        }
    }
}
