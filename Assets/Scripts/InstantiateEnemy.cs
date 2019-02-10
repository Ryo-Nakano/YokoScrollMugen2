using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateEnemy : MonoBehaviour {
	public GameObject enemy;//EnemyプレハブをUnityからアタッチ

	void Start () {
		GameObject instantiatedEnemy = Instantiate(enemy, Vector3.zero, Quaternion.identity) as GameObject;//Enemy生成→生成したEnemyを変数instantiatedEnemyへ格納
		instantiatedEnemy.transform.parent = this.transform;//instantiatedEnemyの親をGroundに設定
        instantiatedEnemy.transform.localPosition = new Vector3(Random.Range(-0.4f, 0.4f), 0.55f, 0);//Enemyの場所をランダムに移動

		Destroy(this.gameObject, 12);//12秒後にDestroy
	}
}
