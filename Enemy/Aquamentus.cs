﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using LegendOfZelda;
using System;
using System.Collections.Generic;

namespace LegendOfZelda
{

	public class Aquamentus : IEnemy
	{
		public enum FireballState { Breathed, NotBreathed}
		public FireballState State { get; protected set; }
		private Random randomStep = new Random();
		public IAquamentusState state;
		public ISprite sprite;
		public ISprite fireballSprite0;
		public ISprite fireballSprite1;
		public ISprite fireballSprite2;
		public IProjectile fireball0;
		public IProjectile fireball1;
		public IProjectile fireball2;
		private RandomEnemyController random;
		protected const float VELOCITY = -8f;
		protected const float VELOCITYYUP = -2f;
		protected const float VELOCITYYDOWN = 2f;



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
			fireballSprite0 = EnemySpriteFactory.Instance.CreateMovingFireballSprite();
			fireballSprite1 = EnemySpriteFactory.Instance.CreateMovingFireballSprite();
			fireballSprite2 = EnemySpriteFactory.Instance.CreateMovingFireballSprite();

			xPos = 400;
			yPos = 200;

			sprite.Position = new Point(xPos, yPos);
			state = new LeftMovingAquamentusState(this);
			State = FireballState.NotBreathed;
			
			fireStep = 0;
			currentStep = 0;
			changeDirection = this.randomStep.Next(10, 20);
			random = new RandomEnemyController(this);
			
		}
		public void BreatheFireball(int xPos, int yPos)
		{
			State = FireballState.Breathed;
			fireball0 = new Projectile(fireballSprite0, new Vector2(xPos, yPos-100), new Vector2(VELOCITY, VELOCITYYUP));
			fireball1 = new Projectile(fireballSprite1, new Vector2(xPos, yPos), new Vector2(VELOCITY, 0));
			fireball2 = new Projectile(fireballSprite2, new Vector2(xPos, yPos+100), new Vector2(VELOCITY, VELOCITYYDOWN));
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
			if (State == FireballState.Breathed)
			{
				fireballSprite0.Update();
				fireballSprite1.Update();
				fireballSprite2.Update();
				fireball0.Update();
				fireball1.Update();
				fireball2.Update();
			}
			currentStep++;

			
			if(currentStep > changeDirection)
			{
				random.Update();
				currentStep = 0;
				changeDirection = this.randomStep.Next(10, 20);
			}
			
			state.Update();
			sprite.Update();
			
			
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			sprite.Draw(spriteBatch);
			if (State == FireballState.Breathed)
			{
				fireball0.Draw(spriteBatch);
				fireball1.Draw(spriteBatch);
				fireball2.Draw(spriteBatch);
			}
			
			
		}

		
		
	}
}