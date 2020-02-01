using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public static class Textures
    {
        private static Texture2D items;
        public static void LoadAllTextures(ContentManager contentManager)
        {
            items = contentManager.Load<Texture2D>("nes_zelda_items_mod");
        }

        public static Texture2D GetItemsSheet()
        {
            return items;
        }
    }
}
