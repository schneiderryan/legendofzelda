using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{

    class RightWall : IDoor
    {
        private Rectangle hitbox;
        public ISprite door;
        public Rectangle Hitbox
        {
            get { return hitbox; }
            protected set { hitbox = value; }
        }


        public RightWall()
        {
            door = RoomSpriteFactory.Instance.CreateRightWall();
            door.Scale = 2.0f;
            door.Position = new Point(448, 144);
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
