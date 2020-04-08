

namespace LegendOfZelda
{
    abstract class RedLinkState : LinkState
    {
        public RedLinkState(IPlayer link) : base(link)
        {
            // nothing needed
        }

        public override void MoveDown()
        {
            link.State = new MovingDownRedLinkState(link);
        }

        public override void MoveLeft()
        {
            link.State = new MovingLeftRedLinkState(link);
        }

        public override void MoveRight()
        {
            link.State = new MovingRightRedLinkState(link);
        }

        public override void MoveUp()
        {
            link.State = new MovingUpRedLinkState(link);
        }

        public override void PickupItem(IItem item, int time, bool twoHands = true)
        {
            link.State = new RedLinkPickupState(link, item, time, twoHands);
        }
    }
}
