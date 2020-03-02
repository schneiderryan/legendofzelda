﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class Room : IRoom
    {
        public IDictionary<string, IDoor> Doors { get; private set; }
        public IList<Rectangle> Hitboxes { get; private set; }
        public IList<IBlock> Blocks { get => blocks; }
        public IList<IMoveableBlock> MoveableBlocks { get; private set; }
        public IList<IEnemy> Enemies { get; private set; }

        private List<IBlock> blocks;
        private IList<INPC> npcs;
        private IList<IItem> items;
        private LegendOfZelda game;
        private ISprite background;

        public Room(LegendOfZelda game, String levelName)
        {
            this.game = game;

            LevelLoader levelLoader = new LevelLoader(levelName, game);

            this.background = levelLoader.LoadBackground();
            this.background.Scale = 2.0f;
            this.background.Position = new Point(0, 0);

            this.Enemies = levelLoader.LoadEnemies();
            this.items = levelLoader.LoadItems();
            this.MoveableBlocks = levelLoader.LoadMoveableBlocks();
            this.blocks = levelLoader.LoadStillBlocks();
            this.blocks.AddRange(MoveableBlocks);
            this.npcs = levelLoader.LoadNPCs();
            this.Doors = levelLoader.LoadDoors();

            Hitboxes = new List<Rectangle>()
            {
                // left hitboxes
                new Rectangle(0, 0, 64, 172),
                new Rectangle(0, 193, 64, 160),

                // top hitboxes
                new Rectangle(0, 0, 240, 64),
                new Rectangle(273, 0, 240, 64),

                // bottom hitboxes
                new Rectangle(0, 289, 240, 64),
                new Rectangle(273, 289, 240, 64),

                // right hitboxes
                new Rectangle(448, 0, 64, 172),
                new Rectangle(448, 190, 64, 160),
            };

            if (levelLoader.RoomNumber() == 15)
            {
                Hitboxes.Clear();
                Hitboxes.Add(new Rectangle(0, 0, 94, 190));
                Hitboxes.Add(new Rectangle(0, 190, 64, 130));
                Hitboxes.Add(new Rectangle(62, 256, 448, 64));
                Hitboxes.Add(new Rectangle(130, 2, 376, 142));
                Hitboxes.Add(new Rectangle(448, 106, 64, 150));
                Hitboxes.Add(new Rectangle(62, 192, 30, 47));
                Hitboxes.Add(new Rectangle(130, 192, 222, 47));
                Hitboxes.Add(new Rectangle(386, 164, 64, 77));
                Hitboxes.Add(new Rectangle(130, 144, 92, 48));
                Hitboxes.Add(new Rectangle(130, 160, 222, 32));
            }
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
                Debug.DrawHitbox(sb, b.Hitbox);
            }

            foreach (IMoveableBlock b in MoveableBlocks)
            {
                b.Draw(sb);
                Debug.DrawHitbox(sb, b.Hitbox);
            }

            foreach (IItem item in items)
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
                enemy.Draw(sb);
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
            foreach (IMoveableBlock b in MoveableBlocks)
            {
                b.Update();
            }

            foreach (IItem item in items)
            {
                item.Update();
            }

            foreach (INPC npc in npcs)
            {
                npc.Update();
            }

            foreach (IEnemy enemy in Enemies)
            {
                enemy.Update();
            }

            foreach (IItem item in items)
            {
                // check collision
                // if intersects then
                // Item.Pickup(IPlayer) ?
            }

            PlayerCollisionDetector.HandlePlayerCollisions(this, game.link);
            EnemyCollisionDetector.HandleEnemyCollisions(this);
        }
    }
}
