﻿using System;
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

    public void Update()
    {
        if (gameMgr.selectPiece)
        {
            gameMgr.objZones[point.y + 1, point.x].SetActive(true);
        }
    }

    public override bool JudgeMove(Point next)
    {
        if (point.x != next.x) return false;
        if (next.y - point.y != 1) return false;

        return true;
    }
}
