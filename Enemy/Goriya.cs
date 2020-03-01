using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Diagnostics;



namespace LegendOfZelda
{

	class Goriya : IEnemy, ICollideable
	{
		
		public enum BoomerangState { Thrown, NotThrown}
		public BoomerangState State { get; protected set; }
		
		private Random randomStep = new Random();
		public LegendOfZelda game;
		public int timer = 192; // to give about 3 seconds
		public int boomerangTimer;
		public ISprite boomerangSprite;
		public IProjectile boomerang;
		//private KeyboardController keyboard;

		private RandomEnemyController random;

		public int x;
		public int y;
		public double numCurrHearts;

		public double currentHearts
		{
			get { return numCurrHearts; }
			set { numCurrHearts = value; }
		}
		public ISprite sprite { get; set; }
		public IEnemyState state { get; set; }
		public Rectangle Hitbox
		{
			get { return sprite.Box; }
		}

		public int X
		{
			get { return x; }
			set { x = value; }
		}
		public int Y
		{
			get { return y; }
			set { y = value; }
		}

		public int xVel { get; set; }
        public int yVel { get; set; }

		public int CurrentStep { get; set; }
        public int changeDirection { get; set; }
		public bool isBeingAttacked { get ; set ; }
		public bool isDead { get; set; }
		public int listIndex { get; set ; }

		public Goriya(LegendOfZelda game)
		{

			this.game = game;
			isBeingAttacked = false;
			isDead = false;
			currentHearts = 2.0;
			sprite = EnemySpriteFactory.Instance.CreateRightMovingGoriyaSprite();
			boomerangSprite = ProjectileSpriteFactory.Instance.CreateBoomerang();
			X = 400;
			Y = 200;
			sprite.Position = new Point(X, Y);
			CurrentStep = 0;
			changeDirection = this.randomStep.Next(0, 150);
			random = new RandomEnemyController(this);
			state = new RightMovingGoriyaState(this);
			State = BoomerangState.NotThrown;
			//boomerang = new EnemyProjectile(boomerangSprite, new Vector2(xPos, yPos), new Vector2(0, 8f));
		}

		public void ThrowBoomerang(int xPos, int yPos, int xVel, int yVel)
		{
			State = BoomerangState.Thrown;
			boomerang = new EnemyProjectile(boomerangSprite, new Vector2(xPos, yPos), new Vector2(xVel, yVel));
		}

		public void ChangeDirection()
		{
			state.ChangeDirection();
		}

		public void BeKilled()
		{
			state.BeKilled();
		}

		public void MoveLeft()
		{
			state.MoveLeft();
			sprite.Position = new Point(this.X, this.Y);
		}

		public void MoveRight()
		{
			state.MoveRight();
			sprite.Position = new Point(this.X, this.Y);
		}

		public void MoveUp()
		{
			state.MoveUp();
			sprite.Position = new Point(this.X, this.Y);
		}
		public void MoveDown()
		{
			state.MoveDown();
			sprite.Position = new Point(this.X, this.Y);
		}

		public void Update()
		{
			
			if(!isDead)
			{
				if (isBeingAttacked)
				{
					timer--;
					if (timer == 0)
					{
						isBeingAttacked = false;
					}
				
				}
				
				
				if (State == BoomerangState.Thrown)
				{
					boomerangSprite.Update();
					boomerang.Update();
				}

				CurrentStep++;
				if (CurrentStep > changeDirection)
				{
					random.Update();
					CurrentStep = 0;
					changeDirection = this.randomStep.Next(0, 150);
				}

				state.Update();
				sprite.Update();
			}
			
		}

		public void Draw(SpriteBatch spriteBatch, Color color)
		{
			if (!isDead)
			{
				if (isBeingAttacked)
				{
					Color hurt1 = new Color(83, 68, 198);
					Color hurt2 = new Color(184, 101, 22);
					Color hurt3 = new Color(76, 80, 69);

					if (timer <= 8 || timer >= 33 && timer <= 40 || timer >= 65 && timer <= 72 || timer >= 97 && timer <= 104 || timer >= 129 && timer <= 136 || timer >= 161 && timer <= 168)
					{
						sprite.Draw(spriteBatch, hurt1);
					}
					else if (timer <= 16 || timer >= 41 && timer <= 48 || timer >= 73 && timer <= 80 || timer >= 105 && timer <= 112 || timer >= 137 && timer <= 144 || timer >= 169 && timer <= 176)
					{
						sprite.Draw(spriteBatch, hurt2);
					}
					else if (timer <= 24 || timer >= 49 && timer <= 56 || timer >= 81 && timer <= 88 || timer >= 113 && timer <= 120 || timer >= 145 && timer <= 152 || timer >= 177 && timer <= 184)
					{
						sprite.Draw(spriteBatch, hurt3);
					}
				}
				else
				{
					sprite.Draw(spriteBatch, Color.White);
				}
				


				if (State == BoomerangState.Thrown)
				{
					boomerang.Draw(spriteBatch);
				}
			}
		}

		public void BeStill()
		{
			throw new NotImplementedException();
		}

		public void UseProjectile(IProjectile projectile)
		{
			throw new NotImplementedException();
		}

		public void Use(IEnemy enemy)
		{
			throw new NotImplementedException();
		}

		public void TakeDamage()
		{
			currentHearts--;
			if (currentHearts == 0)
			{
				isDead = true;
			}
			isBeingAttacked = true;
			

		}
		}
	}
