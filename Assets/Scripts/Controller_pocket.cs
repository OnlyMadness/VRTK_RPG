using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_pocket : MonoBehaviour {
    public GameObject Player_Camera;
    public float range;
    public float distance;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Player_Camera.transform.position;




        //distance = Vector3.Distance(Player_Camera.transform.position, gameObject.transform.position);
        //if (distance <= range)
        //{

            
        //}




    }
}
