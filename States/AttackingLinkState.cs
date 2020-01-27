using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0
{
    class AttackingLinkState : ILinkState
    {
        private Link link;
        public AttackingLinkState(Link link)
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
            //Nothing to do
        }

        public void BeStill()
        {
            link.state = new StillLinkState(link);
        }

        public void Update()
        {
            //Implement how to attack
        }
    }
}
