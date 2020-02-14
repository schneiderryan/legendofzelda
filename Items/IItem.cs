using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public interface IItem
    {
        int X { get; set; }
        int Y { get; set; }
        void Update();
        void Use(IPlayer player);
        void Draw(SpriteBatch sb);
    }
}
