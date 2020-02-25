using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{

    class RightOpen : IDoor
    {
        private Rectangle hitbox;
        public ISprite door;
        public Rectangle Hitbox
        {
            get { return hitbox; }
            protected set { hitbox = value; }
        }


        public RightOpen()
        {
            door = RoomSpriteFactory.Instance.CreateRightOpen();
            door.Scale = 2.0f;
            door.Position = new Point(448, 144);
            hitbox = new Rectangle(door.Position.X, door.Position.Y, 64, 64);
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
