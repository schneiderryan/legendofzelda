using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    interface IItem : ICollideable
    {
        void Update();
        void Use(IPlayer player);
        void Draw(SpriteBatch sb);
    }
}
