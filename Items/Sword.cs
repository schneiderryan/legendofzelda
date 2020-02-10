using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public abstract class Sword : IItem
    {
        public enum SwordState { OnPlayer, OnGround, Thrown }
        public SwordState State { get; protected set; }

        protected ISprite upSprite;
        protected ISprite rightSprite;

        private const float VELOCITY = 12f;
        private IProjectile thrownSword;

        public virtual void ThrowLeft(Vector2 position)
        {
            State = SwordState.Thrown;
            rightSprite.Effects = SpriteEffects.FlipHorizontally;
            thrownSword = new Projectile(rightSprite, position, new Vector2(-VELOCITY, 0));
        }

        public virtual void ThrowRight(Vector2 position)
        {
            State = SwordState.Thrown;
            rightSprite.Effects = SpriteEffects.None;
            thrownSword = new Projectile(rightSprite, position, new Vector2(VELOCITY, 0));
        }

        public virtual void ThrowUp(Vector2 position)
        {
            State = SwordState.Thrown;
            upSprite.Effects = SpriteEffects.None;
            thrownSword = new Projectile(upSprite, position, new Vector2(0, -VELOCITY));
        }

        public virtual void ThrowDown(Vector2 position)
        {
            State = SwordState.Thrown;
            upSprite.Effects = SpriteEffects.FlipVertically;
            thrownSword = new Projectile(upSprite, position, new Vector2(0, VELOCITY));
        }

        public virtual void BeOnGround()
        {
            State = SwordState.OnGround;
            upSprite.Effects = SpriteEffects.None;
        }

        public virtual void BeOnPlayer()
        {
            State = SwordState.OnPlayer;
        }

        public virtual void Draw(SpriteBatch sb)
        {
            if (State == SwordState.OnGround)
            {
                upSprite.Draw(sb);
            }
            else if (State == SwordState.Thrown)
            {
                thrownSword.Draw(sb);
            }
            // don't draw the sword if a player has it
        }

        public virtual void Update()
        {
            if (State == SwordState.Thrown)
            {
                thrownSword.Update();
            }
        }
    }
}
