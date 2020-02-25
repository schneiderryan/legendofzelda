using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{

    class BottomWall : IDoor
    {
        private Rectangle hitbox;
        public ISprite door;
        public Rectangle Hitbox
        {
            get { return hitbox; }
            protected set { hitbox = value; }
        }


        public BottomWall()
        {
            door = RoomSpriteFactory.Instance.CreateBottomWall();
            door.Scale = 2.0f;
            door.Position = new Point(224, 288);
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
