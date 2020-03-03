using Microsoft.Xna.Framework;
using System.Diagnostics;

namespace LegendOfZelda
{
	class Trap : Enemy
	{
		private int timer;
		private int starttimer;
		private LegendOfZelda game;
		private int startY;
		private int startX;
		private bool attack;
		private bool retreat;
		private string dir;

		public Trap(LegendOfZelda loz)
		{
			Sprite = EnemySpriteFactory.Instance.CreateMovingTrapSprite();
			Hitbox = Sprite.Box;
			//X = 400;
			//Y = 200;
			Sprite.Position = new Point(X, Y);
			//TrapState
			State = new EnemyState(this);
			this.VX = 0;
			timer = 0;
			startX = X;
			startY = Y;
			game = loz;
			BeStill();
		}

		public void ChaseRight()
		{
			X += 3;
		}

		public void ChaseUp()
		{
			Y -= 3;
		}

		public void ChaseDown()
		{
			Y += 3;
		}

		public void ChaseLeft()
		{
			X -= 3;
		}

		public void BeStill()
		{
			VY = 0;
			VX = 0;
		}

		public override void Update()
		{
			if(timer==0)
			{
				startX = X;
				System.Diagnostics.Debug.WriteLine("X is set to {0}", X);
				startY = Y;
			}
			timer++;
			if(attack)
			{
				if(dir.Equals("up"))
				{
					if (Y > 163 && !retreat)
					{
						ChaseUp();
					}
					else
					{
						attack = false;
						retreat = true;			
					}
				}
				else if(dir.Equals("down"))
				{
					if (Y < 150 && !retreat)
					{
						ChaseDown();
					}
					else
					{
						attack = false;
						retreat = true;	
					}
				}
				else if (dir.Equals("right"))
				{
					if (X < 230 && !retreat)
					{
						ChaseRight();
					}
					else
					{
						attack = false;
						retreat = true;
					}
				}
				else //must be going left
				{
					if (X > 250 && !retreat)
					{
						ChaseLeft();
					}
					else
					{
						attack = false;
						retreat = true;
					}
				}
			}
			if(retreat)
			{
				if(dir.Equals("up"))
				{
					MoveDown();
				}
				else if(dir.Equals("down"))
				{
					MoveUp();
				}
				else if (dir.Equals("left"))
				{
					MoveRight();
				}
				else
				{
					MoveLeft();
				}
				if (Y == startY && X == startX)
				{
					retreat = false;
					BeStill();
					System.Diagnostics.Debug.WriteLine("Got one to retreat.");
				}
			}
			int linkXPos = game.link.X;
			int linkYPos = game.link.Y;
			if (!attack && !retreat)
			{
				if (linkXPos < (X + 15) && (linkXPos > (X - 15)))
				{
					attack = true;
					if (linkYPos < Y)
					{
						dir = "up";
					}
					else
					{
						dir = "down";
					}
				}
				if (linkYPos < (Y + 20) && (linkYPos > (Y - 20)))
				{
					attack = true;
					if (linkXPos < X)
					{
						dir = "left";
					}
					else
					{
						dir = "right";
					}
				}
			}
			
			
			base.Update();
		}

	}
}
