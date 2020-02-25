﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class Room : IRoom
    {
        public LegendOfZelda game;
        public ISprite background;
        public Dictionary<String, IDoor> doors = new Dictionary<String, IDoor>();
        public List<IEnemy> enemies;
        public List<IItem> items;

        private List<IBlock> blocks;
        private List<IMoveableBlock> moveableBlocks;
        private Rectangle hitboxLeft;
        private Rectangle hitboxTop;
        private Rectangle hitboxBottom;
        private Rectangle hitboxRight1;
        private Rectangle hitboxRight2;
        private List<Rectangle> hitboxes;

        //populate with items and enemies (and player?)
        public Room(LegendOfZelda game, String levelName)
        {
            this.game = game;

            LevelLoader levelLoader = new LevelLoader(levelName, game);

            this.background = levelLoader.LoadBackground();
            this.background.Scale = 2.0f;
            this.background.Position = new Point(0, 0);

            this.enemies = levelLoader.LoadEnemies();
            this.items = levelLoader.LoadItems();
            this.blocks = levelLoader.LoadStillBlocks();
            this.moveableBlocks = levelLoader.LoadMoveableBlocks();

            this.doors = levelLoader.LoadDoors();

            hitboxes = new List<Rectangle>();


            hitboxLeft = new Rectangle(0, 0, 64, 352);
            hitboxes.Add(hitboxLeft);

            hitboxTop = new Rectangle(0, 0, 512, 64);
            hitboxes.Add(hitboxTop);

            hitboxBottom = new Rectangle(0, 288, 512, 64);
            hitboxes.Add(hitboxBottom);

            hitboxRight1 = new Rectangle(448, 0, 64, 160);
            hitboxRight2 = new Rectangle(448, 192, 64, 160);
            hitboxes.Add(hitboxRight1);
            hitboxes.Add(hitboxRight2);
        }

        public void DrawDoor(SpriteBatch sb, Color color)
        {
            foreach(KeyValuePair<String, IDoor> door in doors)
            {
               door.Value.Draw(sb, color);
            }
        }
        public void Draw(SpriteBatch sb, Color color)
        {
            background.Draw(sb);
            foreach (IBlock b in blocks)
            {
                Debug.DrawHitbox(sb, b.Hitbox);
            }

            foreach (IMoveableBlock b in moveableBlocks)
            {
                b.Draw(sb);
                Debug.DrawHitbox(sb, b.Hitbox);
            }

            foreach (IItem item in items)
            {
                item.Draw(sb);
                Debug.DrawHitbox(sb, item.Hitbox);
            }

            foreach (IEnemy enemy in enemies)
            {
                enemy.Draw(sb);
            }

            foreach (Rectangle box in hitboxes)
            {
                Debug.DrawHitbox(sb, box);
            }
        }

        public void EnterRoomAbove()
        {
            //state.EnterRoomAbove();
        }

        public void EnterRoomBelow()
        {
            //state.EnterRoomBelow();
        }

        public void EnterRoomLeft()
        {
            //state.EnterRoomLeft();
        }

        public void EnterRoomRight()
        {
            //state.EnterRoomRight();
        }

        public void Update()
        {
            foreach (KeyValuePair<String, IDoor> door in doors)
            {
                door.Value.Update();
            }

            foreach (IItem item in items)
            {
                item.Update();
            }

            foreach (IEnemy enemy in enemies)
            {
                enemy.Update();
            }
            foreach (IMoveableBlock b in moveableBlocks)
            {
                b.Update();
            }

            // collision stuffs
            foreach (IItem item in items)
            {
                // check collision
                // if intersects then
                // Item.Pickup(IPlayer) ?
            }

            foreach (IEnemy enemy in enemies)
            {
                // check collision
                // if intersects then
                // do things
            }

            BlockCollisionHandler.PlayerBlockCollision(game.link, blocks);
            BlockCollisionHandler.PlayerMoveableBlockCollision(game.link, moveableBlocks);
        }
    }
}
