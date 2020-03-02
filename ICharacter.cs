using Microsoft.Xna.Framework.Graphics;


namespace LegendOfZelda
{
    interface ICharacter : ICollideable
    {
        Team Team { get; set; }
        ISprite Sprite { get; set; }
        void MoveLeft();
        void MoveRight();
        void MoveUp();
        void MoveDown();
        void Update();
    }
}
