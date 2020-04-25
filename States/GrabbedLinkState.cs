

namespace LegendOfZelda
{
    class GrabbedLinkState : LinkState
    {
        public GrabbedLinkState(IPlayer link) : base(link)
        {
            // do nothing
        }

        public override void Attack()
        {
            // do nothing
        }

        public override void BeStill()
        {
            if (link.Color.Equals("green"))
            {
                link.State = new StillUpLinkState(link);
            }
            else if (link.Color.Equals("red"))
            {
                link.State = new StillUpRedLinkState(link);
            }
            else if (link.Color.Equals("blue"))
            {
                link.State = new StillUpBlueLinkState(link);
            }
        }

        public override void FireProjectile()
        {
            // do nothing
        }

        public override void MoveDown()
        {
            // do nothing
        }

        public override void MoveLeft()
        {
            // do nothing
        }

        public override void MoveRight()
        {
            // do nothing
        }

        public override void MoveUp()
        {
            // do nothing
        }

        public override void PickupItem(IItem item, int time, bool twoHands = true)
        {
            // do nothing
        }
    }
}