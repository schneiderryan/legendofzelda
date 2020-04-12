using System.Collections.Generic;


namespace LegendOfZelda
{
    class MoveableBlockVertical : MoveableBlock
    {
        private bool moved;
        public MoveableBlockVertical(IDictionary<string, IDoor> doors) : base(doors)
        {
            moved = false;
        }

        public override void MoveOnceDown()
        {
            State.MoveDown();
        }

        public override void MoveOnceUp()
        {
            
            State.MoveDown();
            if (!moved)
            {
                Sounds.GetSecretSound().Play();
                moved = true;
            }
        }
    }
}
