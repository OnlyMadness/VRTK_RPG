using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Controller_1 : MonoBehaviour {
    public int healht;
	// Use this for initialization
	void Start () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "[VRTK][AUTOGEN][HeadsetColliderContainer]")
        {
            if (gameObject.tag == "health1")
            {
                Player.Life += 10;
                Destroy(gameObject);
            }
            if (gameObject.tag == "health2")
            {
                Player.Life += 30;
                Destroy(gameObject);
            }
            if (gameObject.tag == "health3")
            {
                Player.Life += 50;
                Destroy(gameObject);
            }
        }

    }
    // Update is called once per frame
    void Update () {
		
	}
}
