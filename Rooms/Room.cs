using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendOfZelda
{
    class Room : IRoom
    {
        public IDictionary<string, IDoor> doors;
        public IList<Rectangle> Hitboxes { get; private set; }
        public IList<IBlock> Blocks { get; private set; }
        public ISet<IEnemy> Enemies { get; private set; }
        public IList<IItem> Items { get; private set; }
        private IList<INPC> npcs;
        private LegendOfZelda game;
        private ISprite background;
        public IDictionary<string, IDoor> Doors
        {
            get { return doors; }
            set { doors = value; }
        }
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
                    new Rectangle(0, 0, 64, 172),
                    new Rectangle(0, 193, 64, 160),

                    // top hitboxes
                    new Rectangle(0, 0, 224, 64),
                    new Rectangle(289, 0, 224, 64),

                    // bottom hitboxes
                    new Rectangle(0, 289, 224, 64),
                    new Rectangle(289, 289, 224, 64),

                    // right hitboxes
                    new Rectangle(448, 0, 64, 172),
                    new Rectangle(448, 190, 64, 160),
                };
            }
        }

        public Room(LegendOfZelda game, String levelName)
        {
            this.game = game;

            LevelLoader levelLoader = new LevelLoader(levelName, game);

            this.background = levelLoader.LoadBackground();
            this.background.Scale = 2.0f;
            this.background.Position = new Point(0, 0);

            this.Enemies = levelLoader.LoadEnemies();
            this.Blocks = levelLoader.LoadBlocks();
            this.Items = levelLoader.LoadItems();
            this.npcs = levelLoader.LoadNPCs();
            this.Doors = levelLoader.LoadDoors();
 

            LoadRoomLayout(levelLoader.RoomNumber());
        }

        public void DrawOverlay(SpriteBatch sb)
        {
            foreach (KeyValuePair<String, IDoor> door in Doors)
            {
                if((!(door.Key == "up")) || door.Value is TopOpen )
                {
                    door.Value.Draw(sb);
                    Debug.DrawHitbox(sb, door.Value.Hitbox);
                }
            }
        }

        public void Draw(SpriteBatch sb)
        {
            background.Draw(sb);

            foreach (KeyValuePair<String, IDoor> door in Doors)
            {
                if (door.Key == "up")
                {
                    Debug.DrawHitbox(sb, door.Value.Hitbox);
                    door.Value.Draw(sb);
                }
            }

            foreach (IBlock b in Blocks)
            {
                b.Draw(sb);
                Debug.DrawHitbox(sb, b.Hitbox);
            }

            foreach (IItem item in Items)
            {
                item.Draw(sb);
                Debug.DrawHitbox(sb, item.Hitbox);
            }

            foreach (INPC npc in npcs)
            {
                npc.Draw(sb);
                Debug.DrawHitbox(sb, npc.Hitbox);
            }

            foreach (IEnemy enemy in Enemies)
            {
                enemy.Draw(sb, Color.White);
                Debug.DrawHitbox(sb, enemy.Hitbox);
            }

            foreach (Rectangle box in Hitboxes)
            {
                Debug.DrawHitbox(sb, box);
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
