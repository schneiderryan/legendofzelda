using Microsoft.Xna.Framework;

namespace Sprint0
{
    public interface IPath
    {
        Point Position { get; set; }

        void Update();
    }
}
