using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject cube;
    public GameObject zone;
    
    //選択中の駒
    public Piece selectPiece;

    GameObject[,] objZones;

	// Use this for initialization
	void Start () {

        objZones = new GameObject[9, 9];

        //すべてのマスを透明なCubeで埋める。マスの選択で使う。
        //TODO: Cubeがずれているので調整が必要。
        for (int i = 0; i < 9; i++)
        {
            for(int j = 0; j < 9; j++)
            {
                var obj1 = Instantiate(cube, Vector3.zero, cube.transform.rotation); //Cubeを生成 postion = 0,0,0 rotation = 0,0,0, scale = 1,1,1
                obj1.layer = LayerMask.NameToLayer("Empty"); //レイヤーを設定
                obj1.transform.position = new Vector3(i, 0, j); //データ上の座標とunityの座標を同期
                obj1.GetComponent<MeshRenderer>().enabled = false; //透明にする。

                var obj2 = Instantiate(zone, Vector3.zero, zone.transform.rotation);
                obj2.transform.position = new Vector3(i, -0.2f, j); //データ上の座標とunityの座標を同期
                obj2.SetActive(false);
                objZones[i, j] = obj2;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
        // Input.GetMouseButtonDown(0)でマウスクリック取得
        if (Input.GetMouseButtonDown(0))
        {
            //おまじない♥　詳しくは公式のマニュアル
            Ray ray = new Ray();
            RaycastHit hit = new RaycastHit();
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //マウスクリックした場所からRayを飛ばし、Pieceレイヤーのオブジェクトがあればtrue 
            if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity, 1 << LayerMask.NameToLayer("Piece")))
            {
                //Pieceを継承したコンポーネントを取得。
                selectPiece = hit.collider.gameObject.GetComponent<Piece>();
                
            }
            //透明なCubeを取得
            else if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity, 1 << LayerMask.NameToLayer("Empty")))
            {
                //Debug.Log(hit.collider.gameObject.transform.position.z + " " + hit.collider.gameObject.transform.position.x);
                //すでに駒を選択してあれば、選択したマスに駒を移動。
                if (selectPiece)
                {
                    float x = hit.collider.gameObject.transform.position.x;
                    float y = hit.collider.gameObject.transform.position.z;
                    //Debug.Log(hit.collider.gameObject.transform.position.z + " " + hit.collider.gameObject.transform.position.x);
                    //Debug.Log(x + " " + y);

                    selectPiece.Move(new Point((int)x, (int)y));
                    selectPiece = null;
                }
            }

        }
    }
}
