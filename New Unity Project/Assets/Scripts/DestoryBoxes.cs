using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryBoxes : MonoBehaviour {
   // public GameObject Prefab;
	
	void Start () {
        GameObject.Destroy(gameObject ,Random .Range (2.0f,5.0f));
	}
	
	// Update is called once per frame
	
}
