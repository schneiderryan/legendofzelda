using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class Door : CollideableObject, IDoor
    {
        public ISprite door;


        public virtual void Draw(SpriteBatch sb, Color color)
        {
            door.Scale = 2.0f;
            door.Draw(sb, color);
        }
        
        
        public virtual void Update()
        {
            door.Update();
        }
    }
}
