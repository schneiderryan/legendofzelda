using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0
{
    class StillLinkState : ILinkState
    {
        private Link link;

        public StillLinkState(Link link)
        {
            this.link = link;
        }

        public void MoveUp()
        {
            link.state = new MovingUpLinkState(link);
        }

        public void MoveDown()
        {
            link.state = new MovingDownLinkState(link);
        }

        public void MoveRight()
        {
            link.state = new MovingRightLinkState(link);
        }

        public void MoveLeft()
        {
            link.state = new MovingLeftLinkState(link);
        }

        public void Attack()
        {
            link.state = new AttackingLinkState(link);
        }

        public void BeStill()
        {
            //Nothing to do
        }

        public void Update()
        {
            //Nothing to do
        }
    }
}
