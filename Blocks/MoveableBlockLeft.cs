using System.Collections.Generic;


namespace LegendOfZelda
{
    class MoveableBlockLeft : MoveableBlock
    {
        public MoveableBlockLeft(IDictionary<string, IDoor> doors) : base(doors)
        {
            // nothing needed
        }

        public override void MoveOnceLeft()
        {
            State.MoveLeft();
        }
    }
}
