using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pip_Boy : MonoBehaviour {

	public void Up_Max_Life()
    {
        Player.Max_Life++;
    }
    public void Up_accuracy()
    {
        Player.accuracy++;
    }
    public void Up_Damage()
    {
        Player.damage++;
    }

    public GameObject MainCan;
    public GameObject CharCan;

   

    public void MainCanvas()
    {
        //GameObject.FindGameObjectWithTag("PipMain").SetActive(true);
        //GameObject.FindGameObjectWithTag("PipChar").SetActive(false);
        MainCan.SetActive(true);
        CharCan.SetActive(false);
    }
    public void CharCanvas()
    {
        //GameObject.FindGameObjectWithTag("PipMain").SetActive(false);
        //GameObject.FindGameObjectWithTag("PipChar").SetActive(true);
        MainCan.SetActive(false);
        CharCan.SetActive(true);
    }
}
