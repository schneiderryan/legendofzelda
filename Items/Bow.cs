
namespace LegendOfZelda
{
    class Bow : Item
    {
        public bool HasArrow { get; set; } // todo: change sprite when it has the arrow

        public Bow()
        {
            sprite = ItemSpriteFactory.GetBow();
            Hitbox = sprite.Box;
        }

        public override void Use(IPlayer player)
        {
            if (HasArrow)
            {
                IProjectile proj;
                if (player.color == "red")
                {
                    proj = new RedArrowProjectile(player.direction,
                        player.X, player.Y);
                }
                else
                {
                    proj = new GreenArrowProjectile(player.direction,
                        player.X, player.Y);
                }
                player.UseProjectile(proj);
            }
        }
    }
}
