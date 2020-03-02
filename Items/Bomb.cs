using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    class Bomb : Item
    {
        public enum BombState { Ready, Detonated, Exploding, Used };
        public BombState State { get; private set; }

        private int fuseDelay;

        public Bomb()
        {
            sprite = ItemSpriteFactory.GetBomb();
            sprite.Scale = 2;
            State = BombState.Ready;
            fuseDelay = 60;
            Hitbox = sprite.Box;
        }

        public void Detonate()
        {
            State = BombState.Detonated;
        }

        public override void Update()
        {
            base.Update();
            if (State == BombState.Detonated)
            {
                if (fuseDelay > 0)
                {
                    fuseDelay--;
                }
                else
                {
                    State = BombState.Exploding;
                    sprite = ItemSpriteFactory.GetExplodingBomb();
                }
            }
            else if (State == BombState.Exploding
                    && (sprite as AnimateOnceSprite).AnimationEnded)
            {
                State = BombState.Used;
            }
        }

        public override void Draw(SpriteBatch sb)
        {
            if (State != BombState.Used)
            {
                base.Draw(sb);
            }
        }

        public override void Use(IPlayer player)
        {
            if (player.NumberBombs > 0)
            {
                //place bomb the direction that the player is facing and let it detonate;
            }
        }
    }
}
