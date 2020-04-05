using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace LegendOfZelda
{
    class Door : CollideableObject, IDoor
    {
        public ISprite door;


        public virtual void Draw(SpriteBatch sb, Color color)
        {
            door.Draw(sb, color);
        }

        
        public virtual void Update()
        {
            door.Update();
        }
    }
}
