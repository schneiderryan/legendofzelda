﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public static class Textures
    {
        private static Texture2D link;
        private static Texture2D linkAttackingDown;
        private static Texture2D linkAttackingUp;

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
        private static Texture2D WinCurtain;
        private static Texture2D HUD;
        private static Texture2D HUDBackground;
        private static Texture2D HUDContents;
        private static Texture2D Fonts;
        private static Texture2D FontsTransparent;
        private static Texture2D Map;
        private static Texture2D Inventory;
        private static Texture2D Selector;


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

            rooms = contentManager.Load<Texture2D>("rooms");
            BWRoom = contentManager.Load<Texture2D>("RoomsBW");
            dungeon = contentManager.Load<Texture2D>("dungeon");
            tiles = contentManager.Load<Texture2D>("tiles");

            HUD = contentManager.Load<Texture2D>("HUDbackgroundnewnew");
            HUDBackground = contentManager.Load<Texture2D>("HUDbackground");
            StartMenu = contentManager.Load<Texture2D>("StartMenu");
            WinCurtain = contentManager.Load<Texture2D>("winCurtain");
            HUDContents = contentManager.Load<Texture2D>("hudSpriteSheet");
            Fonts = contentManager.Load<Texture2D>("fonts");
            FontsTransparent = contentManager.Load<Texture2D>("fontskindatransparent");
            Map = contentManager.Load<Texture2D>("mapstuff");
            Inventory = contentManager.Load<Texture2D>("inventory");
            Selector = contentManager.Load<Texture2D>("selector");

            blank = new Texture2D(graphics, 1, 1);
            blank.SetData(new Color[1] { Color.Red });
        }

        public static Texture2D GetMiscSheet()
        {
            return misc;
        }

        public static Texture2D GetHUD()
        {
            return HUD;
        }

        public static Texture2D GetHUDBackground()
        {

            return HUDBackground;
        }

        public static Texture2D GetHUDContents()
        {
            return HUDContents;
        }

        public static Texture2D GetFonts()
        {
            return Fonts;
        }

        public static Texture2D GetTransparentFonts()
        {
            return FontsTransparent;
        }

        public static Texture2D GetMap()
        {
            return Map;
        }

        public static Texture2D GetInventory()
        {
            return Inventory;
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

        public static Texture2D GetWinCurtain()
        {
            return WinCurtain;
        }

        public static Texture2D GetItemSelector()
        {
            return Selector;
        }
    }
}
