using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
    public interface IPath
    {
        Point Position { get; set; }

        void Update();
    }
}
