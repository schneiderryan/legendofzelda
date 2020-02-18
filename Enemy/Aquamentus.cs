using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using LegendOfZelda;
using System;
using System.Collections.Generic;

namespace LegendOfZelda
{

	class Aquamentus : IEnemy
	{
		public enum FireballState { Breathed, NotBreathed}
		public FireballState State { get; protected set; }
		
		public IAquamentusState state;
		public ISprite sprite;
		private ISprite fireballSprite0;
		private ISprite fireballSprite1;
		private ISprite fireballSprite2;
		private IProjectile fireball0;
		private IProjectile fireball1;
		private IProjectile fireball2;
		private Random randomStep = new Random();
		private RandomEnemyController random;
		protected const float VELOCITY = -8f;
		protected const float VELOCITYYUP = -2f;
		protected const float VELOCITYYDOWN = 2f;



		private int xPos;
		private int yPos;
		private int currentStep;
		private int cd;
		public int breathFire;
		public int fireStep;

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

			breathFire = 0;
			fireStep = 0;
			currentStep = 0;
			changeDirection = this.randomStep.Next(10, 20);
			random = new RandomEnemyController(this);
			
		}
		public void BreatheFireball(int xPos, int yPos)
		{
			State = FireballState.Breathed;
			fireball0 = new EnemyProjectile(fireballSprite0, new Vector2(xPos, yPos-100), new Vector2(VELOCITY, VELOCITYYUP));
			fireball1 = new EnemyProjectile(fireballSprite1, new Vector2(xPos, yPos), new Vector2(VELOCITY, 0));
			fireball2 = new EnemyProjectile(fireballSprite2, new Vector2(xPos, yPos+100), new Vector2(VELOCITY, VELOCITYYDOWN));
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

		public void BeStill()
		{
			throw new NotImplementedException();
		}
	}
}