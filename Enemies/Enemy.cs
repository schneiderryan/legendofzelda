using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    abstract class Enemy : CollideableObject, IEnemy
    {
        public  ISprite Sprite { get; set; }
        public IEnemyState State { get; set; }
        
        public int VX { get; set; }
        public int VY { get; set; }
        public Team Team { get; set; } = Team.Enemy;

        public Point Center => Sprite.Box.Center;

        public virtual void Draw(SpriteBatch sb)
        {
            Sprite.Draw(sb);
        }

        public void MoveDown()
        {
            State.MoveDown();
            Sprite.Position = new Point(X, Y);
            Hitbox = Sprite.Box;
        }

        public void MoveLeft()
        {
            State.MoveLeft();
            Sprite.Position = new Point(X, Y);
            Hitbox = Sprite.Box;
        }

        public void MoveRight()
        {
            State.MoveRight();
            Sprite.Position = new Point(X, Y);
            Hitbox = Sprite.Box;
        }

        public void MoveUp()
        {
            State.MoveUp();
            Sprite.Position = new Point(X, Y);
            Hitbox = Sprite.Box;
        }

        public virtual void Update()
        {
            State.Update();
            Sprite.Position = new Point(X, Y);
            Hitbox = Sprite.Box;
            Sprite.Update();
        }
    }
}
