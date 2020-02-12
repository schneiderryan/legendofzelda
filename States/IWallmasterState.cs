﻿using Microsoft.Xna.Framework.Graphics;

public interface IWallmasterState
{
	void ChangeDirection();
	void BeKilled();
	void Update();
    void MoveDown();
    void MoveUp();
    void MoveRight();
    void MoveLeft();
}
