using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : Piece
{

    GameManager gameMgr;

    public void Start()
    {
        gameMgr = GetComponent<GameManager>();
    }

    public override bool JudgeMove(Point next)
    {
        if (point.x != next.x) return false;
        if (next.y - point.y != 1) return false;

        return true;
    }
}
