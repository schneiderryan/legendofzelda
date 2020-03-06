using Microsoft.Xna.Framework;
using System;

namespace LegendOfZelda
{
	class Zol : RandomMovingEnemy
	{
		public Zol()
		{
			Sprite = EnemySpriteFactory.Instance.CreateMovingZolSprite();
			Hitbox = Sprite.Box;
			X = 400;
			Y = 200;
			Sprite.Position = new Point(X, Y);
			State = new EnemyState(this);
			currentHearts = 1;
			attackTimer = 100;
		}
	}
}
