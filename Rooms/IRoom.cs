using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public interface IRoom
    {
       
        void Update();
        void Draw(SpriteBatch sb);
    }
}
