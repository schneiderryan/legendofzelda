using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace LegendOfZelda
{
    interface IDoor: ICollideable
    {
        //fields for types of objects that can spawn

        void Update();
        void Draw(SpriteBatch sb);

        
    }
}
