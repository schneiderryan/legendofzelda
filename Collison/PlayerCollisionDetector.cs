﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    static class PlayerCollisionDetector
    {
        public static void HandlePlayerCollisions(IPlayer player, Room room)
        {
            PlayerMoveableBlockCollision(player, room.moveableBlocks);
            PlayerBlockCollision(player, room.blocks);
            PlayerDoorCollision(player, room.doors);
            PlayerWallCollision(player, room);
            PlayerEnemyCollision(player, room.enemies);
        }

        private static void PlayerBlockCollision(IPlayer player,
                List<IBlock> still)
        {
            foreach (ICollideable s in still)
            {
                Rectangle collision = Rectangle.Intersect(player.Hitbox, s.Hitbox);
                if (!collision.Equals(Rectangle.Empty))
                {
                    PlayerCollisionHandler.HandlePlayerWallBlockCollision(player, collision);
                }
            }
        }

        private static void PlayerDoorCollision(IPlayer player,
                Dictionary<String, IDoor> doors)
        {
            foreach(KeyValuePair<String, IDoor> door in doors)
            {
                Rectangle collision = Rectangle.Intersect(player.Hitbox, door.Value.Hitbox);
                if (!collision.Equals(Rectangle.Empty))
                {
                    if (!door.Key.Equals("Open"))
                    {
                        PlayerCollisionHandler.HandlePlayerWallBlockCollision(player, collision);
                    }
                }  
            }
        }

        private static void PlayerWallCollision(IPlayer player, Room room)
        {
            foreach(Rectangle hitbox in room.hitboxes)
            {
                Rectangle collision = Rectangle.Intersect(player.Hitbox, hitbox);
                if (!collision.Equals(Rectangle.Empty))
                {
                    PlayerCollisionHandler.HandlePlayerWallBlockCollision(player, collision);
                }
            }
        }

        private static void PlayerMoveableBlockCollision(IPlayer player,
                List<IMoveableBlock> moveable)
        {
            foreach (IMoveableBlock m in moveable)
            {
                Rectangle collision = Rectangle.Intersect(player.Hitbox, m.Hitbox);
                if (!collision.Equals(Rectangle.Empty))
                {
                    PlayerCollisionHandler.HandlePlayerMoveableBlockCollision(player, m, collision);
                }
            }
        }

        private static void PlayerEnemyCollision(IPlayer player, List<IEnemy> enemies)
        {
            foreach(IEnemy enemy in enemies)
            {
                Rectangle collision = Rectangle.Intersect(player.Hitbox, enemy.Hitbox);
                if (!collision.Equals(Rectangle.Empty))
                {
                    PlayerCollisionHandler.HandlePlayerEnemyCollision(player, collision);
                }
            }
        }
    }
}
