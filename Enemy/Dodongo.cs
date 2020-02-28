﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using LegendOfZelda;
using System;
using System.Collections.Generic;

namespace LegendOfZelda
{

	class Dodongo : IEnemy, ICollideable
	{
		private Random randomStep = new Random();
		public IDodongoState state;
		public ISprite sprite;
		private RandomEnemyController random;
		private int x;
		private int y;
		private int currentStep;
		private int cd;

		public Rectangle Hitbox
		{
			get { return sprite.Box; }
		}

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
			get { return x; }
			set { x = value; }
		}
		public int Y
		{
			get { return y; }
			set { y = value; }
		}

		public int xVel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int yVel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		

		public Dodongo()
		{
			//dodongos eat bombs then they explode and the dodongo is hurt but not dead yet, takes 3 bombs 
			sprite = EnemySpriteFactory.Instance.CreateUpMovingDodongoSprite();
			x = 400;
			y = 200;
			sprite.Position = new Point(x, y);
			currentStep = 0;
			changeDirection = this.randomStep.Next(0, 150);
			random = new RandomEnemyController(this);
			state = new DownMovingDodongoState(this);
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
	}
}