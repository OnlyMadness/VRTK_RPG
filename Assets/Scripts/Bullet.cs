using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Torso")
        {
            other.GetComponent<Enemy>().Health -= Player.damage;
            if (other.GetComponent<Enemy>().Health <= 0)
                Enemy.Enemy_Dead.GetComponent<Animator>().SetBool("Death", true);
            else
                Enemy.Enemy_Dead.GetComponent<Animator>().SetBool("Hit", true);            
            Destroy(gameObject);
        }
        if (other.name == "Limbs")
        {
            other.GetComponent<Enemy>().Health -= Player.damage/2;
            if (other.GetComponent<Enemy>().Health <= 0)
                Enemy.Enemy_Dead.GetComponent<Animator>().SetBool("Death", true);
            else
                Enemy.Enemy_Dead.GetComponent<Animator>().SetBool("Hit", true);
            Destroy(gameObject);
        }
        if (other.name == "Head")
        {
            other.GetComponent<Enemy>().Health -= Player.damage*2;
            if (other.GetComponent<Enemy>().Health <= 0)
                Enemy.Enemy_Dead.GetComponent<Animator>().SetBool("Death", true);
            else
                Enemy.Enemy_Dead.GetComponent<Animator>().SetBool("Hit", true);
            Destroy(gameObject);
        }
    }
}
