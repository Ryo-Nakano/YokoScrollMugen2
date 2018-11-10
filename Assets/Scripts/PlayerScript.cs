using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーン遷移扱う

public class PlayerScript : MonoBehaviour {

	[SerializeField] float speed;//Playerの移動スピード
	[SerializeField] float jumpPower;//jumpする時の力

	Rigidbody rb;//取得したRigidbodyを入れておく為の変数
	float jumpCount;//jump回数に制限作る為

	void Start () {
		rb = this.gameObject.GetComponent<Rigidbody>();//Rigidbodyを取得→変数rbに格納
	}

	void Update () {
		this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);//Playerの移動

		if(Input.GetKeyDown(KeyCode.Space))//spaceキー押した時
		{
			if(jumpCount < 2)//jumpCount2より小さい時(2回以上ジャンプしてない時)
			{
				rb.velocity = new Vector3(0, jumpPower, 0);//上(y軸方向)にジャンプ
				jumpCount++;//jumpCountに1足す
			}
		}
	}

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Ground")//当たった相手のtagがGroundだった時
		{
			jumpCount = 0;//jumpCountを初期化
		}

		if(col.gameObject.tag == "Enemy")//当たった相手のtagがEnemyだった時
		{
			SceneManager.LoadScene("GameOver");//GameOverシーンに移行
		}
	}
}
