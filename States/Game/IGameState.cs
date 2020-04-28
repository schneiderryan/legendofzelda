using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    interface IGameState
    {
        void ToStart();
        void NewGame();
        void PlayGame();
        void PauseGame();
        void ResumeGame();
        void ChangeRoom();
        void WinGame();
        void LoseGame();
        void SelectItem();
        void Update();
        void Draw();
        void OpenInventory();
        void CloseInventory();
        void SelectMode();
        void CloseItemShop();
        void OpenItemShop();
    }
}