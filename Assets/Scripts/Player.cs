using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public static int Life;
    public int Startlife;
  //  public int StartArmor;
  //  public int Start_Max_Life;
    public double Start_accuracy;
  //  public int Start_damage;
    public int Start_agility;
    public int Start_strange;

    public static int Armor;

    public static bool Stroke_player;
    public static bool Battle;
    public static bool New_level;

    public static int Max_Life;
    public static double accuracy;  //точность
   // public static int damage;
    public static int agility;
    public static int strange;
    public static int points;
    public static int lvl;
    public static int Count_Health;
    public static string Type_Weapon;

    public static int cartridges;
    public static int cartridges_pistol;

    public static bool Shoot;

    void Start()
    {
        Life = Startlife;
        
        agility = Start_agility;     
        strange = Start_strange;
        accuracy = Start_accuracy;

        Type_Weapon = "Руки";
        lvl = 1;
        //Armor = StartArmor;
        // damage = Start_damage;
        Stroke_player = true;
       // Max_Life = Start_Max_Life;
    }
}
