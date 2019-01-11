using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {
    private AudioSource m_AudioSource;
	// Use this for initialization
	void Start () {
        m_AudioSource = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input .GetKey (KeyCode .A ))
        {
            m_AudioSource.Play();

        }


        if (Input.GetKey(KeyCode.Z ))
        {
            m_AudioSource.Pause();

        }
    }
}
