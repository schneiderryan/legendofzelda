using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
	class Trap : Enemy
	{
		public Trap()
		{
			Sprite = EnemySpriteFactory.Instance.CreateMovingTrapSprite();
			Hitbox = Sprite.Box;
			X = 400;
			Y = 200;
			Sprite.Position = new Point(X, Y);
			State = new EnemyState(this);
		}

	}
}
