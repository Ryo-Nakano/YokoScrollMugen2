using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkScript : MonoBehaviour {

	//ぶつかった時呼ばれる
	void OnTriggerEnter(Collider col)//isTriggerにチェック！
	{
		if(col.gameObject.tag == "Player")//当たった相手のtagがMarkだった時
		{
			int randomNum = Random.Range(1, 4);//1-3のどれかをランダム生成
			GameObject ground = Resources.Load("Ground" + randomNum) as GameObject;//Resourcesフォルダ内のGround1-3のどれかを取ってきて、変数groundに格納(GameObject型に変換！)
			Instantiate(ground, new Vector3(this.transform.position.x + 40.0f, -6.0f, 0), Quaternion.identity);//Markから一定距離の場所にGroundをInstantiate
		}
	}
}
