using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class EnemyWallBlockDoorCollision : ICollision
    {
        private IEnemy enemy;
        private Rectangle collision;

        public EnemyWallBlockDoorCollision(IEnemy enemy, in Rectangle collision)
        {
            this.enemy = enemy;
            this.collision = collision;
        }

        public void Handle()
        {
            if (collision.Width > collision.Height)
            {
                if (collision.Y != enemy.Hitbox.Y)
                {
                    enemy.Y -= collision.Height;
                    enemy.MoveUp();
                }
                else
                {
                    enemy.Y += collision.Height;
                    enemy.MoveLeft();
                }
            }
            else
            {
                if (collision.X != enemy.Hitbox.X)
                {
                    enemy.X -= collision.Width;
                    enemy.MoveDown();
                }
                else
                {
                    enemy.X += collision.Width;
                    enemy.MoveRight();
                }
            }
        }
    }
}
