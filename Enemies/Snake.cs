using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{

	class Snake : RandomMovingEnemy
	{
		public Snake(IDictionary<int, IPlayer> players)
		{
			Sprite = EnemySpriteFactory.Instance.CreateUpMovingSnakeSprite();
			Hitbox = Sprite.Box;
			X = 400;
			Y = 200;
			Sprite.Position = new Point(X, Y);
			State = new UpMovingSnakeState(this, players);
			currentHearts = 1;
		}
	}
}