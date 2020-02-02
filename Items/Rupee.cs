using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public class Rupee : IItem
    {
        protected ISprite sprite;

        public Rupee()
        {
            sprite = new AnimatedSprite(Textures.GetItemsSheet(),
                    new Rectangle(61, 34, 8, 16), 2);
        }

        public void Draw(SpriteBatch sb)
        {
            sprite.Draw(sb);
        }
    }
}
