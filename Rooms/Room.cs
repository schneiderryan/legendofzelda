using Microsoft.Xna.Framework;
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
        public IList<IItem> Items { get; private set; }
        public IList<INPC> NPCs { get; private set; }
        public IDictionary<string, IDoor> Doors { get; set; }

        private LegendOfZelda game;
        public ISprite background { get; set; }
        private string level;
        

        private void LoadRoomLayout(int roomNumber)
        {
            if (roomNumber == 15)
            {
                Hitboxes = new List<Rectangle>
                {
                    new Rectangle(94, 100, 64,5),
                    new Rectangle(0, 120, 94, 190),
                    new Rectangle(0, 310, 64, 130),
                    new Rectangle(62, 376, 448, 64),
                    new Rectangle(130, 122, 376, 142),
                    new Rectangle(448, 226, 64, 150),
                    new Rectangle(62, 312, 30, 47),
                    new Rectangle(130, 312, 222, 47),
                    new Rectangle(386, 284, 64, 77),
                    new Rectangle(130, 264, 92, 48),
                    new Rectangle(130, 280, 222, 32),
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
            level = levelName;
            RoomLoader levelLoader = new RoomLoader(levelName, game);

            this.background = RoomSpriteFactory.Instance.CreateRooms(game.xRoom, game.yRoom);
            
            this.background.Position = new Point(0, 0);

            this.Doors = levelLoader.LoadDoors();
            this.Blocks = levelLoader.LoadBlocks(Doors);
            this.Enemies = levelLoader.LoadEnemies(Doors);
            this.Items = levelLoader.LoadItems();
            this.NPCs = levelLoader.LoadNPCs();
            
            if (levelName.Equals("Rooms/Room15.csv"))
            {
                Blocks.ElementAt(0).Y -= 3 * RoomParser.TILE_SIZE;
            }

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
                    if (enemy.item != null)
                    {
                        Item item = enemy.item;
                        item.X = enemy.X;
                        item.Y = enemy.Y;
                        Items.Add(item);
                    }
                    Enemies.Remove(enemy);
                    if (Enemies.Count == 0)
                    {
                        Item item;
                        if (level.Equals("Rooms/Room0.csv"))
                        {
                            item = new Key();
                            item.X = 320;
                            item.Y = 120+255; //before adjustments
                        }
                        else if (level.Equals("Rooms/Room5.csv") || level.Equals("Rooms/Room17.csv"))
                        {
                            item = new Key();
                            item.X = 265;  //265
                            item.Y = 120 + 95; //95 before adjustments
                        }
                        else if (level.Equals("Rooms/Room10.csv"))
                        {
                            item = new Boomerang();
                            item.X = 265;  //265
                            item.Y = 120 + 95; //95 before adjustments
                        }
                        else if (level.Equals("Rooms/Room13.csv"))
                        {
                            item = new HeartContainer();
                            item.X = 385;
                            item.Y = 120+ 160; //before adjustments
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
