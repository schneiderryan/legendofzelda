using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using LegendOfZelda;
using System;
using System.Collections.Generic;

namespace LegendOfZelda
{

	public class Aquamentus : IEnemy
	{
		private Random randomStep = new Random();
		public IAquamentusState state;
		public ISprite sprite;
		public ISprite fireball0;
		public ISprite fireball1;
		public ISprite fireball2;
		private KeyboardController keyboard;
		private RandomEnemyController random;

		public int xFire0;
		public int yFire0;
		public int xFire1;
		public int yFire1;
		public int xFire2;
		public int yFire2;


		public int xPos;
		public int yPos;
		public int currentStep;
		public int changeDirection;
		public int breathFire;
		public int fireStep;

		int IEnemy.currentStep { get ; set ; }
		int IEnemy.changeDirection { get; set; }

		public Aquamentus()
		{
			
			sprite = EnemySpriteFactory.Instance.CreateLeftMovingAquamentusSprite();
			
			xPos = 400;
			yPos = 200;
			
			sprite.Position = new Point(xPos, yPos);
			state = new LeftMovingAquamentusState(this);

			
			breathFire = this.randomStep.Next(10, 50);

			currentStep = 0;
			changeDirection = this.randomStep.Next(0, 150);
			random = new RandomEnemyController(this);
			
		}
		public void BreathFireball()
		{
			state.BreathFireball();
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
			if (currentStep > breathFire)
			{
				
				this.BreathFireball();
			}
			
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
			sprite.Draw(spriteBatch);
		}

		
		
	}
}