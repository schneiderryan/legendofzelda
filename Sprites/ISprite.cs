using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
    public interface ISprite : Drawable
    {
        Point Position { get; set; }
        float Scale { get; set; }
        void Update();
    }
}
