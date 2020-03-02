using Microsoft.Xna.Framework;

namespace LegendOfZelda
{

	class Stalfo : RandomMovingEnemy
	{
		public Stalfo()
		{
			//stalfos can be hit once before they die to the next hit 
			Sprite = EnemySpriteFactory.Instance.CreateMovingStalfoSprite();
			Hitbox = Sprite.Box;
			X = 400;
			Y = 200;
			Sprite.Position = new Point(X, Y);
			State = new EnemyState(this);
			currentHearts = 2;
			attackTimer = 100;
		}

	}
}