using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLife : MonoBehaviour {

	//子弹自动销毁
	void Start () {
        GameObject.Destroy(gameObject ,1.0f);
	}
	
	
	void Update () {
		
	}
}
