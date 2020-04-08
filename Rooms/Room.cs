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
        public IDictionary<string, IDoor> Doors { get; private set; }

        private IList<INPC> npcs;
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
                    new Rectangle(0, 0, 64, 168),
                    new Rectangle(0, 192, 64, 160),
                   
                    // right wall hitboxes
                    new Rectangle(449, 0, 64, 168),
                    new Rectangle(449, 192, 64, 160),

                    // top wall hitboxes
                    new Rectangle(0, 0, 240, 64),
                    new Rectangle(272, 0, 224, 64),

                    // bottom wall hitboxes
                    new Rectangle(0, 289, 240, 64),
                    new Rectangle(272, 289, 224, 64),

                };
            }
        }

        public Room(LegendOfZelda game, String levelName)
        {

            this.game = game;

            RoomLoader levelLoader = new RoomLoader(levelName, game);

            this.background = RoomSpriteFactory.Instance.CreateRooms(game.xRoom, game.yRoom);
            this.background.Scale = 2.0f;
            this.background.Position = new Point(0, 0);

            this.Doors = levelLoader.LoadDoors();
            this.Enemies = levelLoader.LoadEnemies();
            this.Blocks = levelLoader.LoadBlocks(this);
            this.Items = levelLoader.LoadItems();
            this.npcs = levelLoader.LoadNPCs();
            
 

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

            foreach (INPC npc in npcs)
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

            foreach (INPC npc in npcs)
            {
                npc.Update();
            }

            foreach (IEnemy enemy in Enemies.ToList())
            {
                if (enemy.isDead)
                {
                    Enemies.Remove(enemy);
                }
                enemy.Update();
            }
        }

    }
}
