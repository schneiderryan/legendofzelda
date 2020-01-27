using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0
{
    class MovingUpLinkState : ILinkState
    {
        private Link link;

        public MovingUpLinkState(Link link)
        {
            this.link = link;
        }

        public void MoveUp()
        {
            //Nothing to do
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
            link.state = new StillLinkState(link);
        }

        public void Update()
        {
            //Implement how to move up
        }
    }
}
