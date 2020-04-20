using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class ModeSelector
    {
        private LegendOfZelda game;
        private ISprite selectorSprite;
        private int currentDelay;
        private int totalDelay;
        private int x = 60;
        private int normalY = 85;
        private int selectorOffset = 61;
        private int offsetMultiplier = 0;

        private string[] modes;
        public ModeSelector(LegendOfZelda game)
        {
            string[] modes = {"normal", "hard", "sudden death"};
            this.game = game;
            this.selectorSprite = MiscSpriteFactory.Instance.CreateModeSelector();
            currentDelay = 0;
            totalDelay = 5;
            selectorSprite.X = x;
            selectorSprite.Y = normalY;
        }

        public void Update()
        {
            currentDelay++;
            if (currentDelay == totalDelay)
            {
                selectorSprite.Update();
                currentDelay = 0;
            }

            if (game.currentMode.Equals("normal"))
            {
                offsetMultiplier = 0;
            } else if (game.currentMode.Equals("hard"))
            {
                offsetMultiplier = 1;
            } else if (game.currentMode.Equals("sudden death"))
            {
                offsetMultiplier = 2;
            }
            selectorSprite.Y = normalY + offsetMultiplier*selectorOffset;
        }

        public void Draw()
        {
            selectorSprite.Draw(game.spriteBatch);
        }
    }
}
