using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    interface ICharacter : ICollideable
    {
        Point Center { get; }
        Team Team { get; set; }
        ISprite Sprite { get; set; }
        void MoveLeft();
        void MoveRight();
        void MoveUp();
        void MoveDown();
        void Update();
    }
}
