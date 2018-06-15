using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public bool OpenDoorFlag, CloseDoorFlag;
    public float Range_UP, Range_Down;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (OpenDoorFlag)
        {
            if (transform.position.y <= Range_UP)
                transform.Translate(Vector3.up * Time.deltaTime);
            else
                OpenDoorFlag = false;
        }
        if (CloseDoorFlag)
        {
            if (transform.position.y >= Range_Down)
                transform.Translate(Vector3.down * Time.deltaTime);
            else
                CloseDoorFlag = false;
        }
    }

    public void OpenDoor()
    {
        CloseDoorFlag = false;
        Debug.Log("Open");
        OpenDoorFlag = true;
    }
    public void CloseDoor()
    {
        OpenDoorFlag = false;
        Debug.Log("Close");
        CloseDoorFlag = true;
    }
}
