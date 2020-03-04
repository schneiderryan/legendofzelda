using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using LegendOfZelda;
using System;
using System.Collections.Generic;

namespace LegendOfZelda
{

	class LFWallmaster : RandomMovingEnemy
	{
		public LFWallmaster()
		{
			Sprite = EnemySpriteFactory.Instance.CreateMovingLFWallmasterSprite();
			Hitbox = Sprite.Box;
			X = 400;
			Y = 200;
			Sprite.Position = new Point(X, Y);
			State = new EnemyState(this);
			Name = "LFWallmaster";
		}

	}
}