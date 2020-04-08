

namespace LegendOfZelda
{
    abstract class GreenLinkState : LinkState
    {
        public GreenLinkState(IPlayer link) : base(link)
        {
            // nothing needed
        }

        public override void MoveDown()
        {
            link.State = new MovingDownLinkState(link);
        }

        public override void MoveLeft()
        {
            link.State = new MovingLeftLinkState(link);
        }

        public override void MoveRight()
        {
            link.State = new MovingRightLinkState(link);
        }

        public override void MoveUp()
        {
            link.State = new MovingUpLinkState(link);
        }

        public override void PickupItem(IItem item, int time, bool twoHands = true)
        {
            link.State = new GreenLinkPickupState(link, item, time, twoHands);
        }
    }
}
