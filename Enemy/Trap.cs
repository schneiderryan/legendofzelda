using Microsoft.Xna.Framework;
using LegendOfZelda;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{

	class Trap : IEnemy, ICollideable
	{
		private Random randomStep = new Random();
		private double numCurrHearts;
		public double currentHearts
		{
			get { return numCurrHearts; }
			set { numCurrHearts = value; }
		}
		public ISprite sprite { get; set; }
		public IEnemyState state { get; set; }
		private RandomEnemyController random;
		public LegendOfZelda game;
		public int x;
		public int y;

		public Rectangle Hitbox
		{
			get { return sprite.Box; }
		}

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
		public int currentStep;
		public int cd;


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
		public int X
		{
			get { return xPos; }
			set { xPos = value; }
		}
		public int Y
		{
			get { return yPos; }
			set { yPos = value; }
		}

		public Trap(LegendOfZelda loz)
		{

			sprite = EnemySpriteFactory.Instance.CreateMovingTrapSprite();
			xPos = 400;
			yPos = 200;
			sprite.Position = new Point(xPos, yPos);
			currentStep = 0;
			game = loz;
			changeDirection = this.randomStep.Next(0, 150);
			random = new RandomEnemyController(this);
			state = new RightMovingTrapState(this);
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

		public void Draw(SpriteBatch spriteBatch, Color color)
		{
			sprite.Draw(spriteBatch);
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
			throw new NotImplementedException();
		}

		
	}
}