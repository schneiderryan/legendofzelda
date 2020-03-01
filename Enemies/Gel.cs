using Microsoft.Xna.Framework;
using System;

namespace LegendOfZelda
{
	class Gel : RandomMovingEnemy
	{
		public Gel()
		{
			Sprite = EnemySpriteFactory.Instance.CreateMovingGelSprite();
			Hitbox = Sprite.Box;
			X = 400;
			Y = 200;
			Sprite.Position = new Point(X, Y);
			State = new EnemyState(this);
		}
	}
}
