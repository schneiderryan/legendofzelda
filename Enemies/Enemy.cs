using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    abstract class Enemy : CollideableObject, IEnemy
    {
        public ISprite Sprite { get; set; }
        public IEnemyState State { get; set; }
        public bool isDead { get; set; }
        public double currentHearts { get; set; }
        public int VX { get; set; }
        public int VY { get; set; }
        public Team Team { get; set; } = Team.Enemy;

        protected int attackTimer { get; set; }

        private int dieTimer = 13;
        private int spawnTimer = 25;
        private bool isBeingAttacked { get; set; }
        private bool isDying { get; set; }
        private bool isSpawning { get; set; }
        private bool hasSpawned { get; set; }
        private ISprite TempSprite { get; set; }

        public Point Center => Sprite.Box.Center;

        public void Draw(SpriteBatch sb, Color color)
        {
            if (isBeingAttacked)
            {
                
                Color hurt1 = new Color(83, 68, 198);
                Color hurt2 = new Color(184, 101, 22);
                Color hurt3 = new Color(76, 80, 69);
                if (isDying)
                {
                    Sprite.Draw(sb, Color.White);
                }
                else if (attackTimer <= 8 || attackTimer >= 33 && attackTimer <= 40 || attackTimer >= 65 && attackTimer <= 72 || attackTimer >= 97 && attackTimer <= 104 || attackTimer >= 129 && attackTimer <= 136 || attackTimer >= 161 && attackTimer <= 168)
                {
                    Sprite.Draw(sb, hurt1);
                }
                else if (attackTimer <= 16 || attackTimer >= 41 && attackTimer <= 48 || attackTimer >= 73 && attackTimer <= 80 || attackTimer >= 105 && attackTimer <= 112 || attackTimer >= 137 && attackTimer <= 144 || attackTimer >= 169 && attackTimer <= 176)
                {
                    Sprite.Draw(sb, hurt2);
                }
                else if (attackTimer <= 24 || attackTimer >= 49 && attackTimer <= 56 || attackTimer >= 81 && attackTimer <= 88 || attackTimer >= 113 && attackTimer <= 120 || attackTimer >= 145 && attackTimer <= 152 || attackTimer >= 177 && attackTimer <= 184)
                {
                    Sprite.Draw(sb, hurt3);
                }
            }
            else
            {
                Sprite.Draw(sb, color);
            }
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

        public void BeStill()
        {
            State.BeStill();
        }

        public virtual void Update()
        {
            if (!hasSpawned && !isSpawning)
            {
                TempSprite = this.Sprite;
                this.Spawn();
            }
            if (isSpawning)
            {
                spawnTimer--;
                if(spawnTimer == 0)
                {
                    hasSpawned = true;
                    isSpawning = false;
                    this.Sprite = TempSprite;
                }
            }
            if (isBeingAttacked)
            {
                attackTimer--;
                if (attackTimer == 0)
                {
                    isBeingAttacked = false;
                }

            }
            if (currentHearts <= 0 && !isDying)
            {
                this.Die();
            }
            if (isDying)
            {
                dieTimer--;
                if(dieTimer == 0)
                {
                    isDead = true;
                }
            }
                
            State.Update();
            Sprite.Position = new Point(X, Y);
            Hitbox = Sprite.Box;
            Sprite.Update();
        }

        public virtual void TakeDamage(double amount)
        {
            isBeingAttacked = true;
            currentHearts -= amount;
        }

        public void Die()
        {
            isDying = true;
            this.Sprite = EnemySpriteFactory.Instance.CreateDeadEnemy();
        }

        public void Spawn()
        {
            isSpawning = true;
            this.Sprite = EnemySpriteFactory.Instance.CreateNewEnemy();
        }

        public void Knockback(int amountX, int amountY)
        {
            State.Knockback(amountX, amountY);
        }
    }
}
