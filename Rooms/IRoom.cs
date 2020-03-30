using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace LegendOfZelda
{
    interface IRoom
    {
        void Update();
        void Draw(SpriteBatch sb, Color color);
        void DrawOverlay(SpriteBatch sb, Color color);
        IList<Rectangle> Hitboxes { get; }
        IDictionary<string, IDoor> Doors { get; }
        IList<IBlock> Blocks { get; }
        ISet<IEnemy> Enemies { get; }
        IList<IItem> Items { get; }
    }
}
