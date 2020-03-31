using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace LegendOfZelda
{
    class NoDespawnEffect : IDespawnEffect
    {
        public bool Finished => true;

        public void Draw(SpriteBatch sb, Color color)
        {
            // do nothing
        }

        public void Update()
        {
            // do nothing
        }

    }
}
