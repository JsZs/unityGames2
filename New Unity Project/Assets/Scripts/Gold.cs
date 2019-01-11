using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour {
    private Transform m_Transform;
    private GUIText m_GUIText;
	// Use this for initialization
	void Start () {
        m_Transform = gameObject.GetComponent<Transform>();
        m_GUIText=GameObject .Find("Score").GetComponent<GUIText >();//总的一栏重寻找到一列
	}
	
	// Update is called once per frame
	void Update () {
       m_Transform .Rotate(Vector3.up, 10f);
	}

    public void AddScore()
    {
        int s = int.Parse(m_GUIText.text);//text是string类型
        m_GUIText.text =(s +1).ToString ();
    }
}
