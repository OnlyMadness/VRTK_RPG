using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public float range;
    public float distance;

    public int Health;
    public int Damage_enemy;
    public int agility_enemy;

    public GameObject Player_Camera;
    public GameObject Controller_Left;
    public GameObject Controller_Right;
    public static bool Battle;
    public static bool Win;
    public static GameObject Enemy_Dead;
    private Quaternion newRotation;

    public GameObject Player_Camera_Transform;

    // Use this for initialization
    void Start () {
     
	}
	
	// Update is called once per frame
	void Update () {

   

        distance = Vector3.Distance(Player_Camera.transform.position, gameObject.transform.position);
        if (distance <= range)
        {
 
            Vector3 targetPostition = new Vector3(Player_Camera.transform.position.x,
                                        this.transform.position.y,
                                        Player_Camera.transform.position.z);
            this.transform.LookAt(targetPostition);

            Enemy_Dead = gameObject;
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
        }
	}

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }

    public void Zombie_Dead()
    {
        Player.Stroke_player = false;
        Controller_Left.GetComponent<VRTK.VRTK_Pointer>().enabled = true;
        Destroy(gameObject);
        Player.Battle = false;
        Player.lvl++;
        Player.points+=5;
    }

    public void Zombie_Attack()
    {
        Player.Life-=Damage_enemy;
        if (Player.Life <= 0)
            Debug.Log("GameOver");
        else
        {
            Player.Stroke_player = true;
            gameObject.GetComponent<Animator>().SetBool("Attack", false);
        }
    }
    public void Zombie_Hit()
    {
        Player.Stroke_player = false;
        gameObject.GetComponent<Animator>().SetBool("Hit", false);
    }
}
