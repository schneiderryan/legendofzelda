using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using LegendOfZelda;
using System;
using System.Collections.Generic;

namespace LegendOfZelda
{

	public class Gel : IEnemy
	{
		private Random randomStep = new Random();
		public IGelState state;
		public ISprite sprite;
		private RandomEnemyController random;
		
		public int currentStep;
		public int changeDirection;

		int IEnemy.currentStep { get ; set ; }
		int IEnemy.changeDirection { get; set; }
		public int x;
		public int y;
		public int xPos
		{
			get { return x; }
			set { x = value; }
		}

		public int yPos
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


		public Gel()
		{

			sprite = EnemySpriteFactory.Instance.CreateMovingGelSprite();
			xPos = 400;
			yPos = 200;
			sprite.Position = new Point(xPos, yPos);
			currentStep = 0;
			changeDirection = this.randomStep.Next(0, 150);
			random = new RandomEnemyController( this);
			state = new RightMovingGelState(this);
		}

		public void ChangeDirection()
		{
			random.Update();
			currentStep = 0;
			changeDirection = this.randomStep.Next(0, 150);
			state.ChangeDirection();
		}

		public void BeKilled()
		{
			state.BeKilled();
		}

		public void BeStill()
		{
			throw new NotImplementedException();
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
				this.ChangeDirection();
			}
			
			state.Update();
			sprite.Update();
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			sprite.Draw(spriteBatch);
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