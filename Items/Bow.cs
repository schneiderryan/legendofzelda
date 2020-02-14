
namespace LegendOfZelda
{
    public class Bow : Item
    {
        public bool HasArrow { get; set; } // todo: change sprite when it has the arrow

        public Bow()
        {
            sprite = ItemSpriteFactory.GetBow();
        }

        public override void Use(IPlayer player)
        {
            if (HasArrow)
            {
                IProjectile proj;
                if (player.color == "red")
                {
                    proj = new RedArrowProjectile(player.direction,
                        player.xPos, player.yPos);
                }
                else
                {
                    proj = new GreenArrowProjectile(player.direction,
                        player.xPos, player.yPos);
                }
                player.FireProjectile(proj);
            }
        }
    }
}
