using System.Collections.Generic;


namespace LegendOfZelda
{
    class MoveableBlockLeft : MoveableBlock
    {
        private bool moved;
        public MoveableBlockLeft(IDictionary<string, IDoor> doors) : base(doors)
        {
            moved = false;
        }

        public override void MoveOnceLeft()
        {
            
            
            State.MoveLeft();
            if (!moved)
            {
                Sounds.GetSecretSound().Play();
                moved = true;
            }
        }
    }
}
