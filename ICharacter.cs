﻿using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    interface ICharacter : ICollideable, IUpdateable
    {
        Point Center { get; }
        Team Team { get; set; }
        ISprite Sprite { get; set; }
        void MoveLeft();
        void MoveRight();
        void MoveUp();
        void MoveDown();
        void BeStill();
        void Knockback(int amountX, int amountY);
        void TakeDamage(double amount);
    }
}
