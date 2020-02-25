using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{

    class BottomOther : IDoor
    {
        private Rectangle hitbox;
        public ISprite door;
        public Rectangle Hitbox
        {
            get { return hitbox; }
            protected set { hitbox = value; }
        }


        public BottomOther()
        {
            door = RoomSpriteFactory.Instance.CreateBottomOther();
            door.Scale = 2.0f;
            door.Position = new Point(225, 288);
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
