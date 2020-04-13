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
        public IItem Item { get; set; }

        protected int TakeDamageCooldown { get; set; } = 100;
        protected int attackTimer { get; set; } = 0;

        private int dieTimer = 13;
        private int spawnTimer = 25;
        private bool isDying { get; set; }
        private bool isSpawning { get; set; }
        private bool hasSpawned { get; set; }
        private ISprite TempSprite { get; set; }

        public Point Center => Sprite.Box.Center;

        public void Draw(SpriteBatch sb, Color color)
        {
            if (attackTimer > 0 && !(this is Fire))
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
            if (Item != null)
            {
                if (Item is Key)
                {
                    Item.Draw(sb, color);
                }
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
            if (Item != null)
            {
                Item.X = X + 8;
                Item.Y = Y;
            }
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
            if (attackTimer > 0)
            {
                attackTimer--;
            }
            if (currentHearts <= 0.01 && !isDying)
            {
                this.Die();
            }
            if (isDying)
            {
                dieTimer--;
                if (dieTimer == 0)
                {
                    isDead = true;
                }
            }
                
            State.Update();
            Sprite.Position = new Point(X, Y);
            Hitbox = Sprite.Box;
            Sprite.Update();
            if (Item != null)
            {
                Item.Update();
            }
        }

        public virtual void TakeDamage(double amount)
        {
            if (attackTimer == 0)
            {
                Sounds.GetEnemyHurtSound().Play();
                attackTimer = TakeDamageCooldown;
                currentHearts -= amount;
            }
        }

        public virtual void Die()
        {
            Sounds.GetEnemyDieSound().Play();
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
