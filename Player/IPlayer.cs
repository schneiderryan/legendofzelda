﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    interface IPlayer : ICollideable
    {
        ILinkState state { get; set; }
        ISprite sprite { get; set; }
        string direction { get; set; }
        string color { get; set; }
        int numRupees { get; set; }
        double maxHearts { get; set; }
        double currentHearts { get; set; }
        int numberBombs { get; set; }
        Rectangle SpriteBox { get; }
        void MoveLeft();
        void MoveRight();
        void MoveUp();
        void MoveDown();
        void Attack();
        void BeStill();
        void TakeDamage();
        void Update();
        void UseItem(IItem item);
        void UseProjectile(IProjectile projectile);
        void Draw(SpriteBatch sb, Color color);
        void RegisterAttackKeys(List<Keys> attackKeys);
        bool IsAttacking();
    }
}
