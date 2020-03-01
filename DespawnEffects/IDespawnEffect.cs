using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    interface IDespawnEffect
    {
        void Draw(SpriteBatch sb);
        void Update();
        
        bool Finished { get; }
    }
}
