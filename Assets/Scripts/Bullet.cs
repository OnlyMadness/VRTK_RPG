using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

	private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Head")
        {
            //Enemy.Win = true;
            Enemy.Enemy_Dead.GetComponent<Animator>().SetBool("Hit", true);
        //    Enemy.Enemy_Dead.GetComponent<Animator>().SetBool("Death", true);
            Destroy(gameObject);
        }
    }
}
