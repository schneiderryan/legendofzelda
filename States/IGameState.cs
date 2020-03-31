using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    interface IGameState
    {
        void ToStart();
        void PlayGame();
        void PauseGame();
        void ResumeGame();
        void ChangeRoom();
        void WinGame();
        void LoseGame();
        void SelectItem();
        void Update();
        void Draw();
    }
}
