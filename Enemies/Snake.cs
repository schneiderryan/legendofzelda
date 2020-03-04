using Microsoft.Xna.Framework;

namespace LegendOfZelda
{

	class Snake : RandomMovingEnemy
	{
		LegendOfZelda game;

		public Snake(LegendOfZelda loz)
		{
			game = loz;
			Sprite = EnemySpriteFactory.Instance.CreateUpMovingSnakeSprite();
			Hitbox = Sprite.Box;
			X = 400;
			Y = 200;
			Sprite.Position = new Point(X, Y);
			State = new UpMovingSnakeState(this);
			attackTimer = 100;
			currentHearts = 2; 
		}

		public override void Update()
		{
			int linkYPos = game.link.Y;
			int linkXPos = game.link.X;
			if ((linkYPos < (Y + 10)) && (linkYPos > (Y - 10)))
			{
				if (linkXPos < X)
				{
					X -= 4;
					MoveLeft();
				}
				else
				{
					X += 4;
					MoveRight();
				}
			}
			else if ((linkXPos < (X + 10)) && (linkXPos > (X - 10)))
			{
				if (linkYPos < Y)
				{
					Y -= 4;
					MoveUp();
				}
				else
				{
					Y += 4;
					MoveDown();
				}
			}
			base.Update();
		}

	}
}