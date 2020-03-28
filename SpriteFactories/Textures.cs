using Microsoft.Xna.Framework;
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

        private static Texture2D misc;
        private static Texture2D effects;
        private static Texture2D items;
        private static Texture2D enemy;
        private static Texture2D boss;
        private static Texture2D npc;
        private static Texture2D merchant;

        private static Texture2D blank;

        private static Texture2D rooms;
        private static Texture2D BWRoom;
        private static Texture2D dungeon;
        private static Texture2D tiles;

        private static Texture2D StartMenu;


        public static void LoadAllTextures(ContentManager contentManager,
                GraphicsDevice graphics)
        {
            misc = contentManager.Load<Texture2D>("misc");
            items = contentManager.Load<Texture2D>("items_mod");
            effects = contentManager.Load<Texture2D>("weapons_mod");
            enemy = contentManager.Load<Texture2D>("loz_enemy_sheet");
            boss = contentManager.Load<Texture2D>("zelda-sprites-bosses");
            npc = contentManager.Load<Texture2D>("loz_anothertry_npc_sheet");
            merchant = contentManager.Load<Texture2D>("ZeldaSpriteMerchant");

            link = contentManager.Load<Texture2D>("link_mod");
            linkAttackingDown = contentManager.Load<Texture2D>("downAttackingLink");
            linkAttackingUp = contentManager.Load<Texture2D>("upAttackingLink");
            redLinkAttackingDown = contentManager.Load<Texture2D>("downAttackingRedLink");
            redLinkAttackingUp = contentManager.Load<Texture2D>("upAttackingRedLink");

            rooms = contentManager.Load<Texture2D>("rooms");
            BWRoom = contentManager.Load<Texture2D>("RoomsBW");
            dungeon = contentManager.Load<Texture2D>("dungeon");
            tiles = contentManager.Load<Texture2D>("tiles");

            StartMenu = contentManager.Load<Texture2D>("StartMenu");

            blank = new Texture2D(graphics, 1, 1);
            blank.SetData(new Color[1] { Color.Red });
        }

        public static Texture2D GetMiscSheet()
        {
            return misc;
        }
        public static Texture2D GetRoomSheet()
        {
            return rooms;
        }

        public static Texture2D GetDungeonSheet()
        {
            return dungeon;
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

        public static Texture2D GetBlankTexture()
        {
            return blank;
        }

        public static Texture2D GetTileSheet()
        {
            return tiles;
        }

        public static Texture2D GetNPCSheet()
        {
            return npc;
        }

        public static Texture2D GetMerchantSheet()
        {
            return merchant;
        }

        public static Texture2D GetStartMenu()
        {
            return StartMenu;
        }

        public static Texture2D GetBWRoom()
        {
            return BWRoom;
        }
    }
}
