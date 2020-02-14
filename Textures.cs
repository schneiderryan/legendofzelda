using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public static class Textures
    {
        private static Texture2D items;
        private static Texture2D effects;
        private static Texture2D link;

        public static void LoadAllTextures(ContentManager contentManager)
        {
            items = contentManager.Load<Texture2D>("items_mod");
            effects = contentManager.Load<Texture2D>("weapons_mod");
            link = contentManager.Load<Texture2D>("link");
        }

        public static Texture2D GetItemSheet()
        {
            return items;
        }

        public static Texture2D GetWeaponSheet()
        {
            return effects;
        }

        public static Texture2D GetLinkSheet()
        {
            return link;
        }
    }
}
