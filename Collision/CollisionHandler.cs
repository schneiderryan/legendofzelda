using System.Collections.Generic;


namespace LegendOfZelda
{
    class CollisionHandler
    {
        public static void Handle(IEnumerable<ICollision> collisions)
        {
            foreach (ICollision collision in collisions)
            {
                collision.Handle();
            }
        }
    }
}
