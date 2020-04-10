﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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
        public IList<IItem> Items { get; set; }
        public IDictionary<string, IDoor> Doors { get; private set; }

        public IList<INPC> NPCs { get; private set; }
        private string level;
        private LegendOfZelda game;
        private ISprite background;

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
                    // left hitboxes
                    new Rectangle(0, 0, 64, 170),
                    new Rectangle(0, 193, 64, 160),

                    // top hitboxes
                    new Rectangle(0, 0, 224, 64),
                    new Rectangle(289, 0, 224, 64),

                    // bottom hitboxes
                    new Rectangle(0, 289, 224, 64),
                    new Rectangle(289, 289, 224, 64),

                    // right hitboxes
                    new Rectangle(448, 0, 64, 170),
                    new Rectangle(448, 193, 64, 160),
                };
            }
        }

        public Room(LegendOfZelda game, String levelName)
        {
            RoomLoader levelLoader = new RoomLoader(levelName, game);
            level = levelName;
            this.background = levelLoader.LoadBackground();
            this.background.Scale = 2.0f;
            this.background.Position = new Point(0, 0);

            this.Enemies = levelLoader.LoadEnemies();
            this.Blocks = levelLoader.LoadBlocks(this);
            this.Items = levelLoader.LoadItems();
            this.NPCs = levelLoader.LoadNPCs();
            this.Doors = levelLoader.LoadDoors();
            this.game = game;

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

            foreach (IEnemy enemy in Enemies.ToList())
            {
                if (enemy.isDead)
                {
                    if (enemy.item != null)
                    {
                        Item item = enemy.item;
                        item.X = enemy.X;
                        item.Y = enemy.Y;
                        Items.Add(item);
                    }
                    Enemies.Remove(enemy);
                    if(Enemies.Count==0)
                    {
                        Item item;
                        if (level.Equals("Rooms/Room0.csv"))
                        {
                            item = new Key();
                            item.X = 320;
                            item.Y = 255; //before adjustments
                        }
                        else if (level.Equals("Rooms/Room5.csv") || level.Equals("Rooms/Room17.csv"))
                        {
                            item = new Key();
                            item.X = (game.GraphicsDevice.Viewport.Width / 2) + 5;  //265
                            item.Y = (game.GraphicsDevice.Viewport.Height / 3) - 20; //95 before adjustments
                        }
                        else if (level.Equals("Rooms/Room10.csv"))
                        {
                            item = new Boomerang();
                            item.X = (game.GraphicsDevice.Viewport.Width / 2) + 5;  //265
                            item.Y = (game.GraphicsDevice.Viewport.Height / 3) - 20; //95 before adjustments
                        }
                        else if (level.Equals("Rooms/Room13.csv"))
                        {
                            item = new HeartContainer();
                            item.X = 385;
                            item.Y = 160; //before adjustments
                        }
                        else
                        { item = new Key(); }
                        if (!(item.X == 0 && item.Y == 0))
                        {
                            Items.Add(item);
                        }
                    }
                }
                enemy.Update();
            }
        }

    }
}
