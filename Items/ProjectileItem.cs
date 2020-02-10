using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public abstract class ProjectileItem : IItem
    {
        public enum ProjectileState { OnPlayer, OnGround, Thrown }
        public ProjectileState State { get; protected set; }

        protected ISprite upSprite;
        protected ISprite rightSprite;
        protected float initialVelocity = 12f;

        private IProjectile projectile;

        public virtual void ThrowLeft(Vector2 position)
        {
            State = ProjectileState.Thrown;
            rightSprite.Effects = SpriteEffects.FlipHorizontally;
            projectile = new Projectile(rightSprite, position,
                new Vector2(-initialVelocity, 0));
        }

        public virtual void ThrowRight(Vector2 position)
        {
            State = ProjectileState.Thrown;
            rightSprite.Effects = SpriteEffects.None;
            projectile = new Projectile(rightSprite, position,
                new Vector2(initialVelocity, 0));
        }

        public virtual void ThrowUp(Vector2 position)
        {
            State = ProjectileState.Thrown;
            upSprite.Effects = SpriteEffects.None;
            projectile = new Projectile(upSprite, position,
                new Vector2(0, -initialVelocity));
        }

        public virtual void ThrowDown(Vector2 position)
        {
            State = ProjectileState.Thrown;
            upSprite.Effects = SpriteEffects.FlipVertically;
            projectile = new Projectile(upSprite, position,
                new Vector2(0, initialVelocity));
        }

        public virtual void BeOnGround()
        {
            State = ProjectileState.OnGround;
            upSprite.Effects = SpriteEffects.None;
        }

        public virtual void BeOnPlayer()
        {
            State = ProjectileState.OnPlayer;
        }

        public virtual void Draw(SpriteBatch sb)
        {
            if (State == ProjectileState.OnGround)
            {
                upSprite.Draw(sb);
            }
            else if (State == ProjectileState.Thrown)
            {
                projectile.Draw(sb);
            }
            // don't draw the sword if a player has it
        }

        public virtual void Update()
        {
            if (State == ProjectileState.Thrown)
            {
                projectile.Update();
            }
        }
    }
}
