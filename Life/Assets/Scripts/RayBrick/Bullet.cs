using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet: MonoBehaviour {
    private Transform m_transform;
    private Rigidbody m_rigid;
	void Start () {
        m_transform = gameObject.GetComponent<Transform  >();
        m_rigid = gameObject.GetComponent<Rigidbody >();
	}
	
	
	void Update () {
		
	}
}
