using System.Collections.Generic;


namespace LegendOfZelda
{
    class MoveableBlockVertical : MoveableBlock
    {
        public MoveableBlockVertical(IDictionary<string, IDoor> doors) : base(doors)
        {
            // nothing needed
        }

        public override void MoveOnceDown()
        {
            State.MoveDown();
        }

        public override void MoveOnceUp()
        {
            State.MoveDown();
        }
    }
}
