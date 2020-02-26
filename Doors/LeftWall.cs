using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class LeftWall : CollideableObject, IDoor
    {
        public ISprite door;

        public LeftWall()
        {
            door = RoomSpriteFactory.Instance.CreateLeftWall();
            door.Scale = 2.0f;
            door.Position = new Point(0, 145);
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
