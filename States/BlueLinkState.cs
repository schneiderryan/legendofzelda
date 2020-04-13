

namespace LegendOfZelda
{
    abstract class BlueLinkState : LinkState
    {
        public BlueLinkState(IPlayer link) : base(link)
        {
            // nothing needed
        }

        public override void MoveDown()
        {
            link.State = new MovingDownBlueLinkState(link);
        }

        public override void MoveLeft()
        {
            link.State = new MovingLeftBlueLinkState(link);
        }

        public override void MoveRight()
        {
            link.State = new MovingRightBlueLinkState(link);
        }

        public override void MoveUp()
        {
            link.State = new MovingUpBlueLinkState(link);
        }

        public override void PickupItem(IItem item, int time, bool twoHands = true)
        {
            link.State = new BlueLinkPickupState(link, item, time, twoHands);
        }
    }
}
