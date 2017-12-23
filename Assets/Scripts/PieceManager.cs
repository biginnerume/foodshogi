using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceManager : MonoBehaviour {

    int i;

    public GameObject prefabFP;
    public GameObject prefabFL;
    public GameObject prefabFKn;
    public GameObject prefabFS;
    public GameObject prefabFG;
    public GameObject prefabFB;
    public GameObject prefabFR;
    public GameObject prefabFK;
    
    public GameObject prefabSP;
    public GameObject prefabSL;
    public GameObject prefabSKn;
    public GameObject prefabSS;
    public GameObject prefabSG;
    public GameObject prefabSB;
    public GameObject prefabSR;
    public GameObject prefabSK;

    public List<Piece> pieceF; //コレクションを宣言　中身はnull
    public List<Piece> pieceS;


    // Use this for initialization
    void Start () {

        pieceF = new List<Piece>(); //Listのインスタンスを生成している。要素数0
        pieceS = new List<Piece>();

        //UNity上で駒の3Dモデルの生成
        //先手側
        //歩兵
        for(i = 0; i <= 8; i++)
        {
            var model = Instantiate(prefabFP, Vector3.zero, prefabFP.transform.rotation);
            var pieceFP = model.AddComponent<Pawn>();
            pieceFP.Create(new Point(i, 2), model);
            pieceF.Add(pieceFP);           
        }

        //香車
        var model1 = Instantiate(prefabFL, Vector3.zero, prefabFL.transform.rotation);
        var pieceFL1 = model1.AddComponent<Lance>();
        pieceFL1.Create(new Point(0, 0), model1);
        pieceF.Add(pieceFL1);

        var model2 = Instantiate(prefabFL, Vector3.zero, prefabFL.transform.rotation);
        var pieceFL2 = model2.AddComponent<Lance>();
        pieceFL2.Create(new Point(8, 0), model2);
        pieceF.Add(pieceFL2);

        //桂馬
        var model3 = Instantiate(prefabFKn, Vector3.zero, prefabFKn.transform.rotation);
        var pieceFKn1 = model3.AddComponent<Knight>();
        pieceFKn1.Create(new Point(1, 0), model3);
        pieceF.Add(pieceFKn1);

        var model4 = Instantiate(prefabFKn, Vector3.zero, prefabFKn.transform.rotation);
        var pieceFKn2 = model4.AddComponent<Knight>();
        pieceFKn2.Create(new Point(7, 0), model4);
        pieceF.Add(pieceFKn2);

        //銀将
        var model5 = Instantiate(prefabFS, Vector3.zero, prefabFS.transform.rotation);
        var pieceFS1 = model5.AddComponent<Silver>();
        pieceFS1.Create(new Point(2, 0), model5);
        pieceF.Add(pieceFS1);

        var model6 = Instantiate(prefabFS, Vector3.zero, prefabFS.transform.rotation);
        var pieceFS2 = model6.AddComponent<Silver>();
        pieceFS2.Create(new Point(6, 0), model6);
        pieceF.Add(pieceFS2);

        //金将
        var model7 = Instantiate(prefabFG, Vector3.zero, prefabFG.transform.rotation);
        var pieceFG1 = model7.AddComponent<Gold>();
        pieceFG1.Create(new Point(3, 0), model7);
        pieceF.Add(pieceFG1);

        var model8 = Instantiate(prefabFG, Vector3.zero, prefabFG.transform.rotation);
        var pieceFG2 = model8.AddComponent<Gold>();
        pieceFG2.Create(new Point(5, 0), model8);
        pieceF.Add(pieceFG2);

        //角
        var model9 = Instantiate(prefabFB, Vector3.zero, prefabFB.transform.rotation);
        var pieceFB = model9.AddComponent<Bishop>();
        pieceFB.Create(new Point(1, 1), model9);
        pieceF.Add(pieceFB);

        //飛車
        var model10 = Instantiate(prefabFR, Vector3.zero, prefabFR.transform.rotation);
        var pieceFR = model10.AddComponent<Rook>();
        pieceFR.Create(new Point(7, 1), model10);
        pieceF.Add(pieceFR);

        //王
        var model11 = Instantiate(prefabFK, Vector3.zero, prefabFK.transform.rotation);
        var pieceFK = model11.AddComponent<King>();
        pieceFK.Create(new Point(4, 0), model11);
        pieceF.Add(pieceFK);


        //後手側
        //歩兵
        for (i = 0; i <= 8; i++)
        {
            var model = Instantiate(prefabSP, Vector3.zero, prefabSP.transform.rotation);
            var pieceSP = model.AddComponent<Pawn>();
            pieceSP.Create(new Point(i, 6), model);
            pieceS.Add(pieceSP);
        }

        //香車
        var model12 = Instantiate(prefabSL, Vector3.zero, prefabSL.transform.rotation);
        var pieceSL1 = model1.AddComponent<Lance>();
        pieceSL1.Create(new Point(0, 8), model12);
        pieceS.Add(pieceSL1);

        var model13 = Instantiate(prefabSL, Vector3.zero, prefabSL.transform.rotation);
        var pieceSL2 = model2.AddComponent<Lance>();
        pieceSL2.Create(new Point(8, 8), model13);
        pieceS.Add(pieceSL2);

        //桂馬
        var model14 = Instantiate(prefabSKn, Vector3.zero, prefabSKn.transform.rotation);
        var pieceSKn1 = model3.AddComponent<Knight>();
        pieceSKn1.Create(new Point(1, 8), model14);
        pieceS.Add(pieceSKn1);

        var model15 = Instantiate(prefabSKn, Vector3.zero, prefabSKn.transform.rotation);
        var pieceSKn2 = model4.AddComponent<Knight>();
        pieceSKn2.Create(new Point(7, 8), model15);
        pieceS.Add(pieceSKn2);

        //銀将
        var model16 = Instantiate(prefabSS, Vector3.zero, prefabSS.transform.rotation);
        var pieceSS1 = model5.AddComponent<Silver>();
        pieceSS1.Create(new Point(2, 8), model16);
        pieceS.Add(pieceSS1);

        var model17 = Instantiate(prefabSS, Vector3.zero, prefabSS.transform.rotation);
        var pieceSS2 = model6.AddComponent<Silver>();
        pieceSS2.Create(new Point(6, 8), model17);
        pieceS.Add(pieceSS2);

        //金将
        var model18 = Instantiate(prefabSG, Vector3.zero, prefabSG.transform.rotation);
        var pieceSG1 = model7.AddComponent<Gold>();
        pieceSG1.Create(new Point(3, 8), model18);
        pieceS.Add(pieceSG1);

        var model19 = Instantiate(prefabSG, Vector3.zero, prefabSG.transform.rotation);
        var pieceSG2 = model8.AddComponent<Gold>();
        pieceSG2.Create(new Point(5, 8), model19);
        pieceS.Add(pieceSG2);

        //角
        var model20 = Instantiate(prefabSB, Vector3.zero, prefabSB.transform.rotation);
        var pieceSB = model9.AddComponent<Bishop>();
        pieceSB.Create(new Point(1, 7), model20);
        pieceS.Add(pieceSB);

        //飛車
        var model21 = Instantiate(prefabSR, Vector3.zero, prefabSR.transform.rotation);
        var pieceSR = model10.AddComponent<Rook>();
        pieceSR.Create(new Point(7, 7), model21);
        pieceS.Add(pieceSR);

        //王
        var model22 = Instantiate(prefabSK, Vector3.zero, prefabSK.transform.rotation);
        var pieceSK = model11.AddComponent<King>();
        pieceSK.Create(new Point(4, 8), model22);
        pieceS.Add(pieceSK);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
