using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using LegendOfZelda;
using System;
using System.Collections.Generic;

namespace LegendOfZelda
{

	class Trap : IEnemy, ICollideable
	{
		private Random randomStep = new Random();
		public ITrapState state;
		public ISprite sprite;
		private RandomEnemyController random;
		public LegendOfZelda game;
		public int x;
		public int y;
		private bool attacking;
		private bool retreating;
		//private int attackvel;
		private string direction;
		private int attacktimer;

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
			get { return xv; }
			set { xv = value; }
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

		public bool Attacking { get => attacking; set => attacking = value; }
		public bool Retreating { get => retreating; set => retreating = value; }

		public Trap(LegendOfZelda loz)
		{

			sprite = EnemySpriteFactory.Instance.CreateMovingTrapSprite();
			xPos = 400;
			yPos = 200;
			sprite.Position = new Point(xPos, yPos);
			currentStep = 0;
			game = loz;
			attacktimer = 0;
			attacking = false;
			retreating = false;
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

		public void Attack(string dir)
		{
	
				switch (dir)
				{
					case "up":
						Y -= 3;
						break;
					case "down":
						Y += 3;
						break;
					case "left":
						X -= 3;
						break;
					case "right":
						X += 3;
						break;
					default:
						break;
				}					
		}

		public void Update()
		{
			/*currentStep++;
			if(currentStep > changeDirection)
			{
				random.Update();
				currentStep = 0;
				changeDirection = this.randomStep.Next(0, 150);
			}
			*/
			int linkXPos = game.link.X;
			int linkYPos = game.link.Y;
			if(((linkYPos < (Y + 10)) && (linkYPos > (Y - 10))))
			{
				if (attacktimer == 0)
				{
					attacking = true;
					//attacktimer++;
					if(linkXPos<X)
					{
						direction = "left";
					}
					else
					{
						direction = "right";
					}
				}	
				/*
				attacking = true;
				if(linkXPos<X)
				{
					direction = "left";
					//Attack("left");
				}
				else
				{
					direction = "right";
					//Attack("right");
				}
				*/
			}
			else if ((linkXPos < (X + 10)) && (linkXPos > (X - 10)))
			{
				/*
				if ((attacktimer == 0) && (retreating = false))
				{
					attacking = true;
					if (linkYPos < Y)
					{
						direction = "up";
					}
					else
					{
						direction = "down";
					}
				}
				*/
				if (attacktimer == 0)
				{
					attacking = true;
					//attacktimer++;
					if (linkYPos < Y)
					{
						direction = "up";
						//Attack("left");
					}
					else
					{
						direction = "down";
						//Attack("right");
					}
				}
				
			}


			if(attacking)
			{
				attacktimer++;
				Attack(direction);
			}
			if(attacktimer==10)
			{
				attacking = false;
				attacktimer = 0;
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