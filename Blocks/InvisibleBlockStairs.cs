using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace LegendOfZelda
{
    class InvisibleBlockStairs : CollideableObject, IBlock
    {
        public InvisibleBlockStairs()
        {
            Hitbox = new Rectangle(32, 0, 1, RoomParser.TILE_SIZE);
        }

        public void Update()
        {
            // nothing to update
        }

        public void Draw(SpriteBatch sb, Color color)
        {
            // do nothing, it's invisible
        }
    }
}
