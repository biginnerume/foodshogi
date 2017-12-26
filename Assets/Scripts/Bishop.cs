using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bishop : Piece {

    public override bool JudgeMove(Point next)
    {

        if ((next.x - point.x != next.y - point.y) && (next.x - point.x != point.y - next.y)) return false;
        if ((point.x == next.x) && (point.y == next.y)) return false;

        
        return true;
    }

}
