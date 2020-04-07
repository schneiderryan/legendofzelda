using Microsoft.Xna.Framework;


namespace LegendOfZelda
{

	class LFWallmaster : RandomMovingEnemy
	{
		public bool dragging;
		
		public LFWallmaster()
		{
			Sprite = EnemySpriteFactory.Instance.CreateMovingLFWallmasterSprite();
			Hitbox = Sprite.Box;
			X = 400;
			Y = 200;
			Sprite.Position = new Point(X, Y);
			State = new EnemyState(this);
			currentHearts = 1;
		}

	}
}