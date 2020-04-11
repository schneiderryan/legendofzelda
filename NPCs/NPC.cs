using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace LegendOfZelda
{
    abstract class NPC : CollideableObject, INPC
    {
        public Team Team => Team.Link;

        public abstract void Draw(SpriteBatch sb, Color color);

        public abstract void Update();

        //public abstract void TakeDamage();
       
        
    }
}
