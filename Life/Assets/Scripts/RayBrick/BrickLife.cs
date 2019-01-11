using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickLife : MonoBehaviour {

    private Transform m_transform;
	void Start () {
        m_transform = gameObject.GetComponent<Transform >();
	}
	
	// Update is called once per frame
	void Update () {
        if (m_transform.position .y <-0.5)
        {

            GameObject.Destroy(gameObject );
        }
	}
}
