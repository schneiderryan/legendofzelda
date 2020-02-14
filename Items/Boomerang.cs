using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
    public class Boomerang : Item
    {
        public Boomerang()
        {
            sprite = ItemSpriteFactory.GetBoomerang();
        }

        public override void Use(IPlayer player)
        {

        }
    }
}
