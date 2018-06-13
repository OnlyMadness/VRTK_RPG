using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public float range;
    public float distance;
    public GameObject Player;
    public GameObject controller;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        distance = Vector3.Distance(Player.transform.position, gameObject.transform.position);
        if (distance <= range)
        {
            // Destroy(gameObject);
            controller.GetComponent<VRTK.VRTK_BezierPointerRenderer>().enabled = false;
        }
        else
        {
            controller.GetComponent<VRTK.VRTK_BezierPointerRenderer>().enabled = true;
        }
	}

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
