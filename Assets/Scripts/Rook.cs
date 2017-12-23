using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : Piece {

    public override bool JudgeMove(Point next)
    {
        if ((point.x != next.x) && (point.y != next.y)) return false;
        if ((point.x == next.x) && (point.y == next.y)) return false;

        return true;
    }
}
