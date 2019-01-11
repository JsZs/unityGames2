using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTest : MonoBehaviour {
    public GameObject prefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown (KeyCode .Space ))
        {
            GameObject.Instantiate(prefab,Vector3 .zero ,Quaternion .identity );
        }
	}
}
