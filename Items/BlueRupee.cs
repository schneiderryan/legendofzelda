using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
    public class BlueRupee : Rupee
    {
        public BlueRupee()
        {
            sprite = new Sprite(Textures.GetItemsSheet(),
                    new Rectangle(61, 34, 8, 16));
        }
    }
}
