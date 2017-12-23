﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Piece{

    public override bool JudgeMove(Point next)
    {
        if (Mathf.Abs(next.x - point.x) > 1) return false;
        if (Mathf.Abs(next.y - point.y) > 1) return false;
        if ((next.x - point.x == -1) && (next.y - point.y == -1)) return false;
        if ((next.x - point.x == 1) && (next.y - point.y == -1)) return false;
        if ((point.x == next.x) && (point.y == next.y)) return false;

        return true;
    }
}
