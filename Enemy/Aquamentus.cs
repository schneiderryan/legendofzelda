using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using LegendOfZelda;
using System;
using System.Collections.Generic;

namespace LegendOfZelda
{

	class Aquamentus : IEnemy, ICollideable
	{
		public enum FireballState { Breathed, NotBreathed}
		public FireballState State { get; protected set; }

		public LegendOfZelda game;
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
		private int x;
		private int y;
		private int yv;
		private int xv;

		public Rectangle Hitbox
		{
			get { return sprite.Box; }
		}

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

		
		public int currentStep;
		public int changeDirection;
		public int breathFire;
		public int fireStep;

		int IEnemy.CurrentStep { get ; set ; }
		int IEnemy.changeDirection { get; set; }
		
		public Aquamentus(LegendOfZelda game)
		{
			this.game = game;
			sprite = EnemySpriteFactory.Instance.CreateLeftMovingAquamentusSprite();
			fireballSprite0 = ProjectileSpriteFactory.Instance.CreateMovingFireballSprite();
			fireballSprite1 = ProjectileSpriteFactory.Instance.CreateMovingFireballSprite();
			fireballSprite2 = ProjectileSpriteFactory.Instance.CreateMovingFireballSprite();

			X = 400;
			Y = 200;

			sprite.Position = new Point(X, Y);
			state = new LeftMovingAquamentusState(this, game);
			State = FireballState.NotBreathed;

			breathFire = 0;
			fireStep = 0;
			currentStep = 0;
			changeDirection = this.randomStep.Next(10, 20);
			random = new RandomEnemyController(this);
			
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

		public void UseProjectile(IProjectile projectile)
		{
			game.projectiles.Add(projectile);
		}

		public void Use(IEnemy enemy)
		{
			throw new NotImplementedException();
		}
	}
}