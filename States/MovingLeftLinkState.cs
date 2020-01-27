using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0
{
    class MovingLeftLinkState : ILinkState
    {
        private Link link;

        public MovingLeftLinkState(Link link)
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
            //Nothing to do
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
            //Implement how to move left
        }
    }
}
