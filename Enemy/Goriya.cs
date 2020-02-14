using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;


namespace LegendOfZelda
{

	public class Goriya : IEnemy
	{
		private Random randomStep = new Random();
		public IGoriyaState state;
		public ISprite sprite;
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
			xPos = 400;
			yPos = 200;
			sprite.Position = new Point(xPos, yPos);
			currentStep = 0;
			changeDirection = this.randomStep.Next(0, 150);
			random = new RandomEnemyController(this);
			state = new RightMovingGoriyaState(this);
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
		}

		
		
	}
}