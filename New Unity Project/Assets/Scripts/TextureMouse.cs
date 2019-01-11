using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureMouse : MonoBehaviour {
    private GUITexture m_GUITexture;
	// Use this for initialization
	void Start () {
        m_GUITexture = gameObject.GetComponent<GUITexture >();

    }
	
	// Update is called once per frame
	

    void OnMouseEnter()
    {
        m_GUITexture.color = Color.blue ;
    }
    void OnMouseExit()
    {
        m_GUITexture.color = Color.red;
    }
     void OnMouseDown()
    {
        m_GUITexture.color = Color.green ;
    }
}
