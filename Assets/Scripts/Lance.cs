using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lance : Piece {

    public override bool JudgeMove(Point next)
    {
        if (point.x != next.x) return false;
        if (next.y - point.y < 1) return false;

        return true;
    }
}
