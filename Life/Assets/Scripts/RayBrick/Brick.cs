using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    private int x=10;
    private int y=5;
    public GameObject prefabBrick;
    private Ray ray;
    private RaycastHit hit;
    public GameObject prefabBullet;
    private Transform m_transform;//挂载的物体的位置
	void Start () {
        m_transform = gameObject.GetComponent<Transform >();
        createWalls();

    }
	
	
	void Update () {
        hitWalls();

    }

    void createWalls()
    {
        for (int i=0; i<x; i++)
        {
            for (int j=0; j<y; j++)
            {

               GameObject   go= GameObject.Instantiate(prefabBrick ,new Vector3 (i,j,0) ,Quaternion .identity );
                go.GetComponent<MeshRenderer>().material.color = new Color(Random .Range (0f,1.0f), Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f));
            }


        }



    }

    void hitWalls()
    {
        if (Input.GetMouseButtonDown (0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition );
            if (Physics .Raycast (ray,out hit))
            {   //计算子弹方向
                Vector3 position = hit.point - m_transform.position;
                GameObject go=GameObject.Instantiate(prefabBullet ,m_transform.position,Quaternion .identity );//实例化子弹

                //子弹射线
                Debug.DrawRay(m_transform .position ,position ,Color.red );

                //给子弹加力
                go.GetComponent<Rigidbody>().AddForce(position *600);
            }

        }
    }




}
