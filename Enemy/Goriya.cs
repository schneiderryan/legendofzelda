using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;


namespace LegendOfZelda
{

	class Goriya : IEnemy
	{
		
		public enum BoomerangState { Thrown, NotThrown}
		public BoomerangState State { get; protected set; }
		private Random randomStep = new Random();
		public IGoriyaState state;
		public ISprite sprite;
		public int boomerangTimer;
		public ISprite boomerangSprite;
		public IProjectile boomerang;
		//private KeyboardController keyboard;

		private RandomEnemyController random;

		public int x;
		public int y;

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

		private int yv;
		private int xv;

		public int xVel
		{
			get { return yv; }
			set { yv = value; }
		}
		public int yVel
		{
			get { return yv; }
			set { yv = value; }
		}
		
		private int currentStep;
		private int cd;

		public int CurrentStep
		{
			get { return currentStep; }
			set { currentStep = value; }
		}
		public int changeDirection
		{
			get { return cd; }
			set { cd = value; }
		}
		

		public Goriya()
		{
			
			sprite = EnemySpriteFactory.Instance.CreateRightMovingGoriyaSprite();
			boomerangSprite = ProjectileSpriteFactory.Instance.CreateBoomerang();
			X = 400;
			Y = 200;
			sprite.Position = new Point(X, Y);
			currentStep = 0;
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
		}

		public void MoveRight()
		{
			state.MoveRight();
		}

		 public void MoveUp()
		{
			state.MoveUp();
		}
		 public void MoveDown()
		{
			state.MoveDown();
		}

		 public void Update()
		{
			if(State == BoomerangState.Thrown)
			{
				boomerangSprite.Update();
				boomerang.Update();
			}
		
			currentStep++;
			if(currentStep > changeDirection)
			{
				random.Update();
				currentStep = 0;
				changeDirection = this.randomStep.Next(0, 150);
			}
			
			state.Update();
			sprite.Update();
		}

		public void Draw(SpriteBatch spriteBatch)
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
	}
}