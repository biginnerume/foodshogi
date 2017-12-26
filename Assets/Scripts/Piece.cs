using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Piece : MonoBehaviour { //抽象クラス

    //フィールドまたはメンバ
    public Point point { protected set; get; }
    public GameObject model;

    GameManager gameMgr;

    public void Create(Point point, GameObject model)
    {
        this.point = point;
        this.model = model;
        model.transform.position = new Vector3(point.x, 0, point.y); //データ上の座標とunityの座標を同期
    }

    public abstract bool JudgeMove(Point next);

    public void Move(Point next)
    {

        if (!JudgeMove(next)) return;
        Debug.Log(next.x + " " + next.y);

        this.point = next;
        model.transform.position = new Vector3(next.x, 0, next.y); //データ上の座標とunityの座標を同期
    }
}
