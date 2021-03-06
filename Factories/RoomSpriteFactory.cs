﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace LegendOfZelda
{ 
    class RoomSpriteFactory
    {
        private Texture2D roomSheet = Textures.GetRoomSheet();
        private Texture2D puzzleroomSheet = Textures.GetPuzzleRoomSheet();
        private Texture2D dungeonSheet = Textures.GetDungeonSheet();
        private Texture2D tileSheet = Textures.GetTileSheet();
        private static RoomSpriteFactory instance = new RoomSpriteFactory();

        private RoomSpriteFactory() { }

        public static RoomSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }
        internal ISprite CreateRooms(int xRoom, int yRoom)
        {
            return new Sprite(roomSheet, new Rectangle(xRoom, yRoom, 512, 352));
        }
        internal ISprite CreatePuzzleRooms(int xRoom, int yRoom)
        {
            return new Sprite(puzzleroomSheet, new Rectangle(xRoom, yRoom, 512, 352));
        }

        //doors
        public ISprite CreateRightOpen()
        {
            return new Sprite(dungeonSheet, new Rectangle(848, 77, 32, 32));
        }
        public ISprite CreateLeftOpen()
        {
            return new Sprite(dungeonSheet, new Rectangle(848, 44, 32, 32));
        }
        public ISprite CreateTopOpen()
        {
            return new Sprite(dungeonSheet, new Rectangle(848, 11, 32, 32));
        }
        public ISprite CreateBottomOpen()
        {
            return new Sprite(dungeonSheet, new Rectangle(848, 110, 32, 32));
        }


        public ISprite CreateTopWall()
        {
            return new Sprite(dungeonSheet, new Rectangle(815, 11, 32, 32));
        }
        public ISprite CreateRightWall()
        {
            return new Sprite(dungeonSheet, new Rectangle(815, 77, 32, 32));
        }
        public ISprite CreateLeftWall()
        {
            return new Sprite(dungeonSheet, new Rectangle(815, 44, 32, 32));
        }
        public ISprite CreateBottomWall()
        {
            return new Sprite(dungeonSheet, new Rectangle(815, 110, 32, 32));
        }

        public ISprite CreateTopKey()
        {
            return new Sprite(dungeonSheet, new Rectangle(881, 11, 32, 32));
        }
        public ISprite CreateRightKey()
        {
            return new Sprite(dungeonSheet, new Rectangle(881, 77, 32, 32));
        }
        public ISprite CreateLeftKey()
        {
            return new Sprite(dungeonSheet, new Rectangle(881, 44, 32, 32));
        }
        public ISprite CreateBottomKey()
        {
            return new Sprite(dungeonSheet, new Rectangle(881, 110, 32, 32));
        }

        public ISprite CreateTopOther()
        {
            return new Sprite(dungeonSheet, new Rectangle(914, 11, 32, 32));
        }

        

        public ISprite CreateRightOther()
        {
            return new Sprite(dungeonSheet, new Rectangle(914, 77, 32, 32));
        }
        public ISprite CreateLeftOther()
        {
            return new Sprite(dungeonSheet, new Rectangle(914, 44, 32, 32));
        }
        public ISprite CreateBottomOther()
        {
            return new Sprite(dungeonSheet, new Rectangle(914, 110, 32, 32));
        }

        public ISprite CreateTopExploded()
        {
            return new Sprite(dungeonSheet, new Rectangle(947, 11, 32, 32));
        }
        public ISprite CreateRightExploded()
        {
            return new Sprite(dungeonSheet, new Rectangle(947, 77, 32, 32));
        }
        public ISprite CreateLeftExploded()
        {
            return new Sprite(dungeonSheet, new Rectangle(947, 44, 32, 32));
        }
        public ISprite CreateBottomExploded()
        {
            return new Sprite(dungeonSheet, new Rectangle(947, 110, 32, 32));
        }

        //rooms
        public ISprite CreateRoom0(LegendOfZelda game)
        {
            if (game.currentMode.Equals("puzzle"))
            {
                return new Sprite(puzzleroomSheet, new Rectangle(515, 886, 256, 176));
            }
                return new Sprite(roomSheet, new Rectangle(258, 886, 256, 176));
        }
        public ISprite CreateRoom1(LegendOfZelda game)
        {
            if (game.currentMode.Equals("puzzle"))
            {
                return new Sprite(roomSheet, new Rectangle(772, 886, 256, 176));
            }
            return new Sprite(roomSheet, new Rectangle(515, 886, 256, 176));
        }

        public ISprite CreateRoom2(LegendOfZelda game)
        {
            if (game.currentMode.Equals("puzzle"))
            {
                return new Sprite(roomSheet, new Rectangle(1029, 886, 256, 176));
            }
            return new Sprite(roomSheet, new Rectangle(772, 886, 256, 176));
        }

        public ISprite CreateRoom3(LegendOfZelda game)
        {
            if (game.currentMode.Equals("puzzle"))
            {
                return new Sprite(roomSheet, new Rectangle(1286, 886, 256, 176));
            }
            return new Sprite(roomSheet, new Rectangle(515, 709, 256, 176));
        }

        public ISprite CreateRoom4(LegendOfZelda game)
        {
            if (game.currentMode.Equals("puzzle"))
            {
                return new Sprite(roomSheet, new Rectangle(515, 709, 256, 176));
            }
            return new Sprite(roomSheet, new Rectangle(258, 532, 256, 176));
        }

        public ISprite CreateRoom5(LegendOfZelda game)
        {
            if (game.currentMode.Equals("puzzle"))
            {
                return new Sprite(roomSheet, new Rectangle(772, 709, 256, 176));
            }
            return new Sprite(roomSheet, new Rectangle(515, 532, 256, 176));
        }

        public ISprite CreateRoom6(LegendOfZelda game)
        {
            if (game.currentMode.Equals("puzzle"))
            {
                return new Sprite(roomSheet, new Rectangle(1029, 709, 256, 176));
            }
            return new Sprite(roomSheet, new Rectangle(772, 532, 256, 176));
        }

        public ISprite CreateRoom7(LegendOfZelda game)
        {
            if (game.currentMode.Equals("puzzle"))
            {
                return new Sprite(roomSheet, new Rectangle(1286, 709, 256, 176));
            }
            return new Sprite(roomSheet, new Rectangle(1, 355, 256, 176));
        }

        public ISprite CreateRoom8(LegendOfZelda game)
        {
            if (game.currentMode.Equals("puzzle"))
            {
                return new Sprite(roomSheet, new Rectangle(515, 532, 256, 176));
            }
            return new Sprite(roomSheet, new Rectangle(258, 355, 256, 176));
        }

        public ISprite CreateRoom9(LegendOfZelda game)
        {
            if (game.currentMode.Equals("puzzle"))
            {
                return new Sprite(roomSheet, new Rectangle(772, 532, 256, 176));
            }
            return new Sprite(roomSheet, new Rectangle(515, 355, 256, 176));
        }

        public ISprite CreateRoom10(LegendOfZelda game)
        {
            if (game.currentMode.Equals("puzzle"))
            {
                return new Sprite(roomSheet, new Rectangle(1029, 532, 256, 176));
            }
            return new Sprite(roomSheet, new Rectangle(772, 355, 256, 176));
        }

        public ISprite CreateRoom11(LegendOfZelda game)
        {
            if (game.currentMode.Equals("puzzle"))
            {
                return new Sprite(roomSheet, new Rectangle(1286, 532, 256, 176));
            }
            return new Sprite(roomSheet, new Rectangle(1029, 355, 256, 176));
        }

        public ISprite CreateRoom12(LegendOfZelda game)
        {
            if (game.currentMode.Equals("puzzle"))
            {
                return new Sprite(roomSheet, new Rectangle(258, 355, 256, 176));
            }
            return new Sprite(roomSheet, new Rectangle(515, 178, 256, 176));
        }
        public ISprite CreateRoom13(LegendOfZelda game)
        {
            if (game.currentMode.Equals("puzzle"))
            {
                return new Sprite(roomSheet, new Rectangle(515, 355, 256, 176));
            }
            return new Sprite(roomSheet, new Rectangle(1029, 178, 256, 176));
        }

        public ISprite CreateRoom14(LegendOfZelda game)
        {
            if (game.currentMode.Equals("puzzle"))
            {
                return new Sprite(roomSheet, new Rectangle(772, 355, 256, 176));
            }
            return new Sprite(roomSheet, new Rectangle(1286, 178, 256, 176));
        }

        public ISprite CreateRoom15(LegendOfZelda game)
        {
            if (game.currentMode.Equals("puzzle"))
            {
                return new Sprite(roomSheet, new Rectangle(1029, 355, 256, 176));
            }
            return new Sprite(roomSheet, new Rectangle(1, 1, 256, 176));
        }

        public ISprite CreateRoom16(LegendOfZelda game)
        {
            if (game.currentMode.Equals("puzzle"))
            {
                return new Sprite(roomSheet, new Rectangle(1286, 355, 256, 176));
            }
            return new Sprite(roomSheet, new Rectangle(258, 1, 256, 176));
        }

        public ISprite CreateRoom17()
        {
            return new Sprite(roomSheet, new Rectangle(515, 1, 256, 176));
        }


        public ISprite CreateBlock()
        {
            return new Sprite(tileSheet, new Rectangle(16, 0, 16, 16));
        }

        public ISprite CreateStair()
        {
            return new Sprite(tileSheet, new Rectangle(32, 0, 16, 16));
        }
    }
    
}
