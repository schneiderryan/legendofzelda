﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendOfZelda
{
    class Room : IRoom
    {
        public IList<Rectangle> Hitboxes { get; private set; }
        public IList<IBlock> Blocks { get; private set; }
        public ISet<IEnemy> Enemies { get; private set; }
        public IList<IItem> Items { get; private set; }
        public IList<INPC> NPCs { get; private set; }
        public IDictionary<string, IDoor> Doors { get; set; }

        private LegendOfZelda game;
        public ISprite background { get; set; }
        

        private void LoadRoomLayout(int roomNumber)
        {
            if (roomNumber == 15)
            {
                Hitboxes = new List<Rectangle>
                {
                    new Rectangle(0, 0, 94, 190),
                    new Rectangle(0, 190, 64, 130),
                    new Rectangle(62, 256, 448, 64),
                    new Rectangle(130, 2, 376, 142),
                    new Rectangle(448, 106, 64, 150),
                    new Rectangle(62, 192, 30, 47),
                    new Rectangle(130, 192, 222, 47),
                    new Rectangle(386, 164, 64, 77),
                    new Rectangle(130, 144, 92, 48),
                    new Rectangle(130, 160, 222, 32),
                };
            }
            else
            {
                Hitboxes = new List<Rectangle>()
                {

                    // left wall hitboxes
                    new Rectangle(0, 120, 64, 168),
                    new Rectangle(0, 312, 64, 160),
                   
                    // right wall hitboxes
                    new Rectangle(449, 120, 64, 168),
                    new Rectangle(449, 312, 64, 160),

                    // top wall hitboxes
                    new Rectangle(0, 120, 240, 64),
                    new Rectangle(272, 120, 224, 64),

                    // bottom wall hitboxes
                    new Rectangle(0, 409, 240, 64),
                    new Rectangle(272, 409, 224, 64),

                };
            }
        }

        public Room(LegendOfZelda game, String levelName)
        {

            this.game = game;

            RoomLoader levelLoader = new RoomLoader(levelName, game);

            this.background = RoomSpriteFactory.Instance.CreateRooms(game.xRoom, game.yRoom);
            
            this.background.Position = new Point(0, 0);

            this.Doors = levelLoader.LoadDoors();
            this.Blocks = levelLoader.LoadBlocks(Doors);
            this.Enemies = levelLoader.LoadEnemies(Doors);
            this.Items = levelLoader.LoadItems();
            this.NPCs = levelLoader.LoadNPCs();
            
 

            LoadRoomLayout(levelLoader.RoomNumber());
        }

        public void DrawOverlay(SpriteBatch sb, Color color)
        {
            foreach (KeyValuePair<String, IDoor> door in Doors)
            {
                if((!(door.Key == "up")) || door.Value is TopOpen )
                {
                    door.Value.Draw(sb, color);
                }
            }
        }

        public void Draw(SpriteBatch sb, Color color)
        {
            background.Draw(sb, color);
            foreach (KeyValuePair<String, IDoor> door in Doors)
            {
                if (door.Key == "up")
                {
                    door.Value.Draw(sb, color);
                }
            }

            foreach (IBlock b in Blocks)
            {
                b.Draw(sb, color);
            }

            foreach (IItem item in Items)
            {
                item.Draw(sb, color);
            }

            foreach (INPC npc in NPCs)
            {
                npc.Draw(sb, color);
            }

            foreach (IEnemy enemy in Enemies)
            {
                enemy.Draw(sb, color);
            }
        }

        public void Update()
        {
            this.background = RoomSpriteFactory.Instance.CreateRooms(game.xRoom, game.yRoom);
            foreach (IEnemy enemy in Enemies.ToList())
            {
                if (enemy.isDead)
                {
                    Enemies.Remove(enemy);
                }
                enemy.Update();
            }
            foreach (KeyValuePair<String, IDoor> door in Doors)
            {
                door.Value.Update();
            }
            foreach (KeyValuePair<String, IDoor> door in Doors)
            {
                door.Value.Update();
            }

            foreach (IBlock block in Blocks)
            {
                block.Update();
            }

            foreach (IItem item in Items)
            {
                item.Update();
            }

            foreach (INPC npc in NPCs)
            {
                npc.Update();
            }

            
        }

    }
}
