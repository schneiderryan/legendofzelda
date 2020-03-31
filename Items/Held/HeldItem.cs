using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace LegendOfZelda
{
    abstract class HeldItem : IHeldItem
    {
        protected ISprite sprite;

        public int X
        {
            get => sprite.X;
            set => sprite.X = value;
        }

        public int Y
        {
            get => sprite.Y;
            set => sprite.Y = value;
        }

        public void Draw(SpriteBatch sb, Color color)
        {
            sprite.Draw(sb, color);
        }

        public abstract void Use(IPlayer player);
    }
}
