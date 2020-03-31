using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    class MoveableBlockVertical : IMoveableBlock
    {
        private readonly IMoveableBlock block;

        public MoveableBlockVertical(IRoom room)
        {
            block = new MoveableBlock(room);
        }

        public Rectangle Hitbox => block.Hitbox;

        public int X { get => block.X; set => block.X = value; }
        public int Y { get => block.Y; set => block.Y = value; }

        public void Draw(SpriteBatch sb, Color color)
        {
            block.Draw(sb, color);
        }

        public void MoveOnceDown()
        {
            block.MoveOnceDown();
        }

        public void MoveOnceLeft()
        {
            // no op
        }

        public void MoveOnceRight()
        {
            // no op
        }

        public void MoveOnceUp()
        {
            block.MoveOnceUp();
        }

        public void Update()
        {
            block.Update();
        }
    }
}
