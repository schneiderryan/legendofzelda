using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;


namespace LegendOfZelda
{

	class Goriya : IEnemy, ICollideable
	{
		
		public enum BoomerangState { Thrown, NotThrown}
		public BoomerangState State { get; protected set; }
		
		private Random randomStep = new Random();
		
		
		public int boomerangTimer;
		public ISprite boomerangSprite;
		public IProjectile boomerang;
		//private KeyboardController keyboard;

		private RandomEnemyController random;

		public int x;
		public int y;
		private double numCurrHearts;

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


        public Goriya()
		{
			
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
			if(State == BoomerangState.Thrown)
			{
				boomerangSprite.Update();
				boomerang.Update();
			}
		
			CurrentStep++;
			if(CurrentStep > changeDirection)
			{
				random.Update();
				CurrentStep = 0;
				changeDirection = this.randomStep.Next(0, 150);
			}
			
			state.Update();
			sprite.Update();
		}

		public void Draw(SpriteBatch spriteBatch, Color color)
		{
			sprite.Draw(spriteBatch, Color.White);
			if(State == BoomerangState.Thrown)
			{
				boomerang.Draw(spriteBatch);
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
			//still need to figure this out 
			
		}
	}
}