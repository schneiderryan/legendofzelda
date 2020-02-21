using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    interface IItem : ICollideable
    {
        int X { get; set; }
        int Y { get; set; }
        void Update();
        void Use(IPlayer player);
        void Draw(SpriteBatch sb);
    }
}
