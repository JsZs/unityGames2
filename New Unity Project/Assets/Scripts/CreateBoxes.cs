using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBoxes : MonoBehaviour {

    public GameObject goPrefab;

    void Start()
    {
        /* Vector3 p = new Vector3(Random.Range(-4.0f, 4.0f),3.0f, Random.Range(-4.0f, 4.0f));

         GameObject.Instantiate(goPrefab, p, Quaternion.identity);
         */

        InvokeRepeating("CreateMoreBoxes", 2.0f, 1.0f);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            CreateMoreBoxes();
        }
        if (Input.GetKeyDown (KeyCode.Z ))
        {
            CancelInvoke();

        }
        //如果按Z，实行CancelInvoke(); 
    }


    void CreateMoreBoxes()
    {
        for (int i= 0;i<5;i++) { 
        
        
            Vector3 p = new Vector3(Random.Range(-4.0f, 4.0f), 3.0f, Random.Range(-4.0f, 4.0f));

            GameObject.Instantiate(goPrefab, p, Quaternion.identity);

        

    }

    }
}
