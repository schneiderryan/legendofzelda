using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace LegendOfZelda
{
    interface IRoom
    {
        void Update();
        void Draw(SpriteBatch sb);
        void DrawOverlay(SpriteBatch sb);
        IList<Rectangle> Hitboxes { get; }
        IDictionary<string, IDoor> Doors { get; }
        IList<IBlock> Blocks { get; }
        IList<IMoveableBlock> MoveableBlocks { get; }
        IList<IEnemy> Enemies { get; }
    }
}
