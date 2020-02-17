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
		public int xPos;
		public int yPos;
		public int currentStep;
		public int changeDirection;

		int IEnemy.currentStep { get ; set ; }
		int IEnemy.changeDirection { get; set; }

		public Goriya()
		{
			
			sprite = EnemySpriteFactory.Instance.CreateRightMovingGoriyaSprite();
			boomerangSprite = ProjectileSpriteFactory.Instance.CreateBoomerang();
			xPos = 400;
			yPos = 200;
			sprite.Position = new Point(xPos, yPos);
			currentStep = 0;
			changeDirection = this.randomStep.Next(0, 150);
			random = new RandomEnemyController(this);
			state = new RightMovingGoriyaState(this);
			State = BoomerangState.NotThrown;
			//boomerang = new EnemyProjectile(boomerangSprite, new Vector2(xPos, yPos), new Vector2(0, 8f));
		}

		public void ThrowBoomerang(int xPos, int yPos)
		{
			State = BoomerangState.Thrown;
			boomerang = new EnemyProjectile(boomerangSprite, new Vector2(xPos, yPos), new Vector2(0, -4f));
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
	}
}