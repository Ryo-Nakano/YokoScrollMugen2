using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	[SerializeField] GameObject player;//PlayerをUnityからアタッチ

	void Start () {
		
	}

	void Update () {
		//Cameraの位置を補正(Playerの横方向の動きにだけ同期させる)
		this.transform.position = new Vector3(player.transform.position.x + 5, this.transform.position.y, this.transform.position.z); 
	}
}
