using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    class MoveableBlockLeft : IMoveableBlock
    {
        private readonly IMoveableBlock block;

        public MoveableBlockLeft(IRoom room)
        {
            block = new MoveableBlock(room);
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
            block.MoveOnceLeft();
        }

        public void MoveOnceRight()
        {
            // no op
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
