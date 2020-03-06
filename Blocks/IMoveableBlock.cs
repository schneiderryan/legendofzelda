using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    interface IMoveableBlock : IBlock
    {
        void MoveOnceUp();
        void MoveOnceDown();
        void MoveOnceLeft();
        void MoveOnceRight();
    }
}
