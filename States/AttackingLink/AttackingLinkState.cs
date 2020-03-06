using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
    abstract class AttackingLinkState : ILinkState
    {
        protected int attackTimer = 20;
        public void MoveUp() { }
        public void MoveDown() { }
        public void MoveRight() { }
        public void MoveLeft() { }
        public void Attack() { }
        public void BeStill() { }
        public void Projectile() { }
        public abstract void Update();

        
    }
}
