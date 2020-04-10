using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class MoveableBlock : CollideableObject, IMoveableBlock
    {
        public IBlockState State { get; set; }

        protected ISprite sprite;
        protected IDictionary<string, IDoor> doors;

        public MoveableBlock(IDictionary<string, IDoor> doors)
        {
            this.doors = doors;
            sprite = RoomSpriteFactory.Instance.CreateBlock();
            State = new MoveableBlockState(this, doors);
            Hitbox = new Rectangle(0, 0, RoomParser.TILE_SIZE, RoomParser.TILE_SIZE);
        }

        public virtual void Draw(SpriteBatch sb, Color color)
        {
            sprite.Draw(sb, color);
        }

        public virtual void MoveOnceUp()
        {
            // no op
        }

        public virtual void MoveOnceDown()
        {
            // no op
        }

        public virtual void MoveOnceLeft()
        {
            // no op
        }

        public virtual void MoveOnceRight()
        {
            // no op
        }

        public virtual void Update()
        {
            State.Update();
            sprite.Position = new Point(X, Y);
        }

    }
}
