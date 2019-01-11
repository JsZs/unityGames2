using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTest : MonoBehaviour {
    private Ray ray;
    private RaycastHit hit;
	void Start () {
		
	}
	
	// Update is called once per   frame
	void Update () {
        CameraSendRay();
        
	}


    void CameraSendRay()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);//创建射线，射线方向是鼠标点击位置
        }
        if (Physics.Raycast(ray, out hit))
        {
            GameObject.Destroy(hit.collider.gameObject);
        }
    }

}
