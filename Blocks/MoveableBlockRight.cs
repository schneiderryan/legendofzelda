using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    class MoveableBlockRight : IMoveableBlock
    {
        private readonly IMoveableBlock block;

        public MoveableBlockRight()
        {
            block = new MoveableBlock();
        }

        public Rectangle Hitbox => block.Hitbox;

        public int X { get => block.X; set => block.X = value; }
        public int Y { get => block.Y; set => block.Y = value; }

        public void Draw(SpriteBatch sb)
        {
            block.Draw(sb);
        }

        public void MoveOnceDown()
        {
            // no op
        }

        public void MoveOnceLeft()
        {
            // no op
        }

        public void MoveOnceRight()
        {
            block.MoveOnceRight();
        }

        public void MoveOnceUp()
        {
            // no op
        }

        public void Update()
        {
            block.Update();
        }
    }
}
