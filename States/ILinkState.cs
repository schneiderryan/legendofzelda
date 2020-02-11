﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    interface ILinkState
    {
        void MoveUp();
        void MoveDown();
        void MoveRight();
        void MoveLeft();
        void Attack();
        void BeStill();
        void TakeDamage();
        void Update();
    }
}
