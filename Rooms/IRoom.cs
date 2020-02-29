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
        List<Rectangle> Hitboxes { get; }
        Dictionary<string, IDoor> Doors { get; }
        List<IBlock> Blocks { get; }
        List<IMoveableBlock> MoveableBlocks { get; }
    }
}
