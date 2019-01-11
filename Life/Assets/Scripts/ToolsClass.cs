using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsClass : MonoBehaviour {
    private float num = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.A ))
        {
            Debug.Log("宽度"+Screen.width);
            Debug.Log("高度" + Screen.height);
            Debug.Log(Time.deltaTime);//渲染完上一帧需要时间，只读
        }
        num = Mathf.Lerp(num,10,Time.deltaTime);//第三个是时间增量 
        Debug.Log("num:"+num );
	}
}
