using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
	class Trap : Enemy
	{
		private int timer;

		private ICollection<IPlayer> players;
		private int startY;
		private int startX;
		private bool attack;
		private bool retreat;
		private string dir;
		private int roommidheight;
		private int roommidwidth;

		public Trap(ICollection<IPlayer> players)
		{
			Sprite = EnemySpriteFactory.Instance.CreateMovingTrapSprite();
			Hitbox = Sprite.Box;
			Sprite.Position = new Point(X, Y);
			State = new EnemyState(this);
			this.VX = 0;
			timer = 0;
			startX = X;
			startY = Y;
			this.players = players;
			BeStill();
			currentHearts = 1;
			roommidheight = 276;
			roommidwidth = 240;
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

		public override void TakeDamage(double amount)
		{
			// do nothing
		}

		public override void Update()
		{
			if(timer==0)
			{
				startX = X;
				startY = Y;
			}
			timer++;
			if(attack)
			{
				if(dir.Equals("up"))
				{
					if (Y > roommidheight+6 && !retreat)
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
					if (Y < roommidheight-6 && !retreat)
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
					if (X < roommidwidth-10 && !retreat)
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
					if (X > roommidwidth+10 && !retreat)
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
				}
			}
			if (!attack && !retreat)
			{
				foreach (IPlayer player in players)
				{
					int linkXPos = player.X;
					int linkYPos = player.Y;
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
			}
			base.Update();
		}
	}
}
