using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace LegendOfZelda
{
    abstract class Door : CollideableObject, IDoor
    {
        protected ISprite door;

        public override int X
        {
            get => base.X;
            set
            {
                base.X = value;
                door.X = value;
            }
        }

        public override int Y
        {
            get => base.Y;
            set
            {
                base.Y = value;
                door.Y = value;
            }
        }

        public virtual void Draw(SpriteBatch sb, Color color)
        {
            door.Scale = 2.0f;
            door.Draw(sb, color);
        }
        
        
        public virtual void Update()
        {
            door.Update();
        }
    }
}
