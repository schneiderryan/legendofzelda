using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;


namespace LegendOfZelda
{
	class Aquamentus : RandomMovingEnemy
	{
		public ICollection<IProjectile> projectiles;
		public IPlayer player;
		private IDictionary<string, IDoor> doors;
		
		public Aquamentus(IDictionary<string, IDoor> doors,
				ICollection<IProjectile> projectiles, IPlayer player)
			: base(30)
		{
			this.doors = doors;
			this.projectiles = projectiles;
			this.player = player;
			Sprite = EnemySpriteFactory.Instance.CreateMovingAquamentusSprite();
			Hitbox = Sprite.Box;
			X = 400;
			Y = 200;
			Sprite.Position = new Point(X, Y);
			State = new NotBreathingAquamentusState(this);
			controller.Directions = new ICommand[]
			{
				new EnemyMoveLeftCommand(this),
				new EnemyMoveRightCommand(this),
			};
			currentHearts = 6;
			attackTimer = 100;
		}

		public override void Die()
		{
			base.Die();
			foreach (KeyValuePair<string, IDoor> door in doors.ToList())
			{
				if (door.Key == "right" && door.Value is RightOther)
				{
					doors.Remove("right");
					doors.Add("right", new RightOpen());
				}
			}
		}

	}
}
