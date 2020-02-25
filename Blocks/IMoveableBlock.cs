using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    interface IMoveableBlock : IBlock
    {
        void Draw(SpriteBatch sb);
        void Update();
        void MoveOnceUp();
        void MoveOnceDown();
    }
}
