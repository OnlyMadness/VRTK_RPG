﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public float range;
    public float distance;
    public GameObject Player_Camera;
    public GameObject Controller_Left;
    public GameObject Controller_Right;
    public static bool Battle;
    public static bool Win;
    public static GameObject Enemy_Dead;
	// Use this for initialization
	void Start () {
        Enemy_Dead = gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        distance = Vector3.Distance(Player_Camera.transform.position, gameObject.transform.position);
        if (distance <= range)
        {
            gameObject.GetComponent<Animator>().SetBool("Battle",true);
            Controller_Left.GetComponent<VRTK.VRTK_Pointer>().enabled = false;
            Player.Battle = true;
        }
        if (Player.Battle)
        {
            if (Player.Stroke_player)
            {
                Controller_Left.GetComponent<VRTK.VRTK_ControllerEvents>().enabled = true;              
            }
            else
            {
                Controller_Left.GetComponent<VRTK.VRTK_ControllerEvents>().enabled = false;
                gameObject.GetComponent<Animator>().SetBool("Attack", true);
            }
            if (Win)
            {
                Controller_Left.GetComponent<VRTK.VRTK_Pointer>().enabled = true;
                Player.Battle = false;
            }
        }
	}

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }

    public void Zombie_Dead()
    {
        Destroy(gameObject);
    }

    public void Zombie_Attack()
    {
        Player.Stroke_player = true;
        gameObject.GetComponent<Animator>().SetBool("Attack", false);
    }
    public void Zombie_Hit()
    {
        Player.Stroke_player = true;
        gameObject.GetComponent<Animator>().SetBool("Hit", false);
        Player.Stroke_player = false;
    }
}
