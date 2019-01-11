using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Transform m_Transform;
    private Rigidbody m_Rigidbody;
    public GameObject prefab_gold;
	// Use this for initialization
	void Start () {
        m_Transform = gameObject.GetComponent<Transform>();
        m_Rigidbody = gameObject.GetComponent<Rigidbody>();
       
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            m_Rigidbody.MovePosition(m_Transform.position+Vector3.forward*0.2f);

        }
        if (Input.GetKey(KeyCode.A))
        {
            m_Rigidbody.MovePosition(m_Transform.position + Vector3.left * 0.2f);

        }
        if (Input.GetKey(KeyCode.S))
        {
            m_Rigidbody.MovePosition(m_Transform.position + Vector3.back * 0.2f);

        }
        if (Input.GetKey(KeyCode.D))
        {
            m_Rigidbody.MovePosition(m_Transform.position + Vector3.right * 0.2f);

        }


    }
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag =="Box")
        {
            Vector3 position =coll.gameObject .transform.position;//掉落盒子的位置
            GameObject.Destroy(coll.gameObject);
            GameObject.Instantiate(prefab_gold  ,position+Vector3 .forward   ,Quaternion.identity );//在消失的盒子位置生成金币
        }


    
    }


    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Gold")
        {
            GameObject.Destroy(collider.gameObject);
           collider.gameObject.SendMessage("AddScore");//或者collider.gameObject.GetComponent<Gold>().AddScore();
        }

    }
    

}
