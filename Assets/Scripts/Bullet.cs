using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "Torso")
        {
            Enemy.Enemy_Dead.GetComponent<Enemy>().Health -= Player.strange;
            if (Enemy.Enemy_Dead.GetComponent<Enemy>().Health <= 0)
                Enemy.Enemy_Dead.GetComponent<Animator>().SetBool("Death", true);
            else
                Enemy.Enemy_Dead.GetComponent<Animator>().SetBool("Hit", true);
            Destroy(gameObject);
        }
        if (other.tag == "Limbs")
        {
            Enemy.Enemy_Dead.GetComponent<Enemy>().Health -= Player.strange / 2;
            if (Enemy.Enemy_Dead.GetComponent<Enemy>().Health <= 0)
                Enemy.Enemy_Dead.GetComponent<Animator>().SetBool("Death", true);
            else
                Enemy.Enemy_Dead.GetComponent<Animator>().SetBool("Hit", true);
            Destroy(gameObject);
        }
        if (other.tag == "Head")
        {
            Enemy.Enemy_Dead.GetComponent<Enemy>().Health -= Player.strange * 2;
            if (Enemy.Enemy_Dead.GetComponent<Enemy>().Health <= 0)
                Enemy.Enemy_Dead.GetComponent<Animator>().SetBool("Death", true);
            else
                Enemy.Enemy_Dead.GetComponent<Animator>().SetBool("Hit", true);
            Destroy(gameObject);
        }
    }
}
