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
			State = new UpMovingSnakeState(this, game.link);
			attackTimer = 100;
			currentHearts = 2;
			Name = "Snake";
		}
		
	}
}