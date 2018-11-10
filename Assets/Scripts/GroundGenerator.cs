using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour {

	[SerializeField] GameObject player;//UnityからPlayerを格納
	[SerializeField] GameObject[] grounds = new GameObject[3];//Unityから生成するGroundのPrefabをアタッチ
	[SerializeField] GameObject enemy;//UnityからEnemyプレハブをアタッチ

	float border = 5;
	float playerStartPosX;//Playerの初期x座標
	float playerNowPosX;//Playerの現在x座標
	GameObject instantiatedGround;


	void Start () {
		player = GameObject.Find("Player");//Hierarcyの中から名前が"Player"のものを探して来て取得→変数playerに格納

		playerStartPosX = player.transform.position.x;//最初の基準値となるPlayerの
		InstantiateEnemy();
	}

	void Update () {
		GenerateGround();//Groundを一定の間隔で生成
	}

    //Groundを一定の間隔で生成
	void GenerateGround()
	{
		playerNowPosX = player.transform.position.x;//Playerの現在x座標を変数playerNowPosXに格納
        float playerDistance = playerNowPosX - playerStartPosX;//Playerの移動距離(playerNowPosXとplayerStartPosXの差分)を変数playerDistanceに格納
        if (playerDistance > border)
        {
            //ステージ生成
            Debug.Log("ステージ生成");
			Instantiate(grounds[Random.Range(0, 3)], new Vector3(player.transform.position.x + 40, -6f, 0), Quaternion.identity);//Playerの一定距離だけ先にステージ生成(-5.5fはステージ生成の位置補正の為)
            playerDistance = 0;//playerDistanceのリセット
            border = 20;//borderの再設定
            playerStartPosX = playerNowPosX;//playerStartPosの再設定
        }
	}

    //Ground生成と同時にEnemyを生成する関数
	void InstantiateEnemy()
	{
		
	}
}
