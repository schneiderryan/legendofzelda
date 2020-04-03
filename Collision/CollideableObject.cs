using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
    abstract class CollideableObject : ICollideable
    {
        public const int KNOCKBACK = LevelParser.TILE_SIZE * 2;

        private Rectangle hitbox = new Rectangle(0, 0,
                LevelParser.TILE_SIZE, LevelParser.TILE_SIZE);

        public virtual Rectangle Hitbox
        {
            get { return hitbox; }
            protected set { hitbox = value; }
        }

        // X & Y properties so that hitbox X & Y can be modified ez
        public virtual int X
        {
            get { return hitbox.X; }
            set { hitbox.X = value; }
        }

        public virtual int Y
        {
            get { return hitbox.Y; }
            set { hitbox.Y = value; }
        }
    }
}
