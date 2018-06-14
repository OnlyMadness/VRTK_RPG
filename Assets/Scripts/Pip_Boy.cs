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
}
