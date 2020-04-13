using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class ProjectileManager : IProjectileManager
    {
        private ICollection<IProjectile> projectiles;
        private IList<IDespawnEffect> effects;
        private ICollection<IProjectile> buffer;

        public ProjectileManager()
        {
            effects = new List<IDespawnEffect>();
            projectiles = new HashSet<IProjectile>();
            buffer = new LinkedList<IProjectile>();
        }

        public int Count => projectiles.Count;

        public bool IsReadOnly => false;

        public void Add(IProjectile projectile)
        {
            buffer.Add(projectile);
        }

        public void Clear()
        {
            effects.Clear();
            projectiles.Clear();
        }

        public bool Contains(IProjectile item)
        {
            return projectiles.Contains(item);
        }

        public void CopyTo(IProjectile[] array, int arrayIndex)
        {
            projectiles.CopyTo(array, arrayIndex);
        }

        public void Draw(SpriteBatch sb, Color color)
        {
            foreach (IProjectile projectile in projectiles)
            {
                projectile.Draw(sb, color);
            }
            foreach (IDespawnEffect effect in effects)
            {
                effect.Draw(sb, color);
            }
        }

        public IEnumerator<IProjectile> GetEnumerator()
        {
            return projectiles.GetEnumerator();
        }

        public bool Remove(IProjectile projectile)
        {
            effects.Add(projectile.GetDespawnEffect());
            return projectiles.Remove(projectile);
        }

        public void Update()
        {
            foreach (IProjectile projectile in projectiles)
            {
                projectile.Update();
            }
            for (int i = effects.Count - 1; i >= 0; i--)
            {
                if (effects[i].Finished)
                {
                    effects.RemoveAt(i);
                }
                else
                {
                    effects[i].Update();
                }
            }
            foreach (IProjectile projectile in buffer)
            {
                projectiles.Add(projectile);
            }
            buffer.Clear();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return projectiles.GetEnumerator();
        }
    }
}
