using Microsoft.Xna.Framework.Graphics;


namespace LegendOfZelda
{
    class BowAndArrow : IHeldItem
    {
        bool hasArrow;
        bool hasBow;
        ISprite bow;
        ISprite arrow;

        public BowAndArrow()
        {
            hasBow = false;
            hasArrow = false;
            bow = ItemSpriteFactory.GetBow();
            arrow = ItemSpriteFactory.GetArrow();
        }

        public int X
        {
            get => arrow.X;
            set
            {
                arrow.X = value;
                bow.X = arrow.Box.Width + value + 1;
            }
        }
        public int Y
        {
            get => arrow.Y;
            set
            {
                arrow.Y = value;
                bow.Y = value;
            }
        }

        public void FoundArrow()
        {
            hasArrow = true;
        }

        public void FoundBow()
        {
            hasBow = true;
        }

        public void Draw(SpriteBatch sb)
        {
            if (hasBow)
            {
                bow.Draw(sb);
            }
            if (hasArrow)
            {
                arrow.Draw(sb);
            }
        }

        public void Use(IPlayer player)
        {
            if (hasBow && hasArrow && player.Inventory.Rupees > 0)
            {
                IProjectile proj = new GreenArrowProjectile(player.Direction,
                        player.Center.X, player.Center.Y);
                proj.OwningTeam = Team.Link;
                player.UseProjectile(proj);
                player.Inventory.Rupees -= 1;
            }
        }
    }
}
