using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    interface IDespawnEffect : IDrawable, IUpdateable
    {   
        bool Finished { get; }
    }
}
