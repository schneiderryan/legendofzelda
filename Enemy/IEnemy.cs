﻿using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public interface IEnemy
    {
        int CurrentStep { get; set; }
        int changeDirection { get; set; }
        int X { get; set; }
        int Y { get; set; }
        void MoveLeft();
        void MoveRight();
        void MoveUp();
        void MoveDown();

        void BeStill();
        void Update();

        void Draw(SpriteBatch spriteBatch);
    }
}
