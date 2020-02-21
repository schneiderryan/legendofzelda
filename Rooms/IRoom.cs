using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public interface IRoom
    {
        //fields for types of objects that can spawn
        void Update();
        void Draw(SpriteBatch sb, Color color);
        void EnterRoomBelow();
        void EnterRoomAbove();
        void EnterRoomLeft();
        void EnterRoomRight();
    }
}
