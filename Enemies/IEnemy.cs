using Microsoft.Xna.Framework.Graphics;


namespace LegendOfZelda
{
    interface IEnemy : ICharacter
    {
        IEnemyState State { get; set; }
        int VX { get; set; }
        int VY { get; set; }
        void Draw(SpriteBatch spriteBatch);
    }
}
