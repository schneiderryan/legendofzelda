
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace LegendOfZelda
{
    interface IEnemy : ICharacter
    {
        IEnemyState State { get; set; }
        bool isDead { get; set; }
        double currentHearts { get; set; }
        int VX { get; set; }
        int VY { get; set; }
        IItem Item { get; set; }
        void Draw(SpriteBatch spriteBatch, Color color);
        void Die();
        void Spawn();
        void DropItem();
    }
}