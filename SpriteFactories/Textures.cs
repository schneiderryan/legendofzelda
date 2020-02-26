using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public static class Textures
    {
        private static Texture2D link;
        private static Texture2D linkAttackingDown;
        private static Texture2D linkAttackingUp;
        private static Texture2D redLinkAttackingDown;
        private static Texture2D redLinkAttackingUp;

        private static Texture2D effects;
        private static Texture2D items;
        private static Texture2D enemy;
        private static Texture2D boss;
        private static Texture2D bossmod;

        public static void LoadAllTextures(ContentManager contentManager)
        {
            items = contentManager.Load<Texture2D>("items_mod");
            effects = contentManager.Load<Texture2D>("weapons_mod");
            enemy = contentManager.Load<Texture2D>("loz_enemy_sheet");
            boss = contentManager.Load<Texture2D>("zelda-sprites-bosses");
            bossmod = contentManager.Load<Texture2D>("zelda-sprites-bosses-willmod");

            link = contentManager.Load<Texture2D>("link_mod");
            linkAttackingDown = contentManager.Load<Texture2D>("downAttackingLink");
            linkAttackingUp = contentManager.Load<Texture2D>("upAttackingLink");
            redLinkAttackingDown = contentManager.Load<Texture2D>("downAttackingRedLink");
            redLinkAttackingUp = contentManager.Load<Texture2D>("upAttackingRedLink");
        }

        public static Texture2D GetItemSheet()
        {
            return items;
        }

        public static Texture2D GetWeaponSheet()
        {
            return effects;
        }

        public static Texture2D GetEnemySheet()
        {
            return enemy;
        }

        public static Texture2D GetBossSheet()
        {
            return boss;
        }

        public static Texture2D GetBossModSheet()
        {
            return bossmod;
        }

        public static Texture2D GetLinkSheet()
        {
            return link;
        }

        public static Texture2D GetLinkAttackingUp()
        {
            return linkAttackingUp;
        }

        public static Texture2D GetLinkAttackingDown()
        {
            return linkAttackingDown;
        }

        public static Texture2D GetRedLinkAttackingUp()
        {
            return redLinkAttackingUp;
        }

        public static Texture2D GetRedLinkAttackingDown()
        {
            return redLinkAttackingDown;
        }
    }
}
