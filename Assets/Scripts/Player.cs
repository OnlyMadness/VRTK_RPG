using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public static int Life;
    public int Startlife;
    public int StartArmor;
    public int Start_Max_Life;
    public double Start_accuracy;
    public double Start_damage;

    public static int Armor;

    public static bool Stroke_player;
    public static bool Battle;
    public static bool New_level;

    public static int Max_Life;
    public static double accuracy;  //точность
    public static double damage;
    

    void Start()
    {
        Life = Startlife;
        Armor = StartArmor;

        Stroke_player = true;

        Max_Life = Start_Max_Life;
        accuracy = Start_accuracy;
        damage = Start_damage;
    }
}
