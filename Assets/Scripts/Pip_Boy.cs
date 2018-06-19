using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pip_Boy : MonoBehaviour {

	public void UpAgility()
    {
        Player.agility++;
        Player.points--;
    }
    public void UpAccuracy()
    {
        Player.accuracy++;
        Player.points--;
    }
    public void UpStrange()
    {
        Player.strange++;
        Player.points--;
    }
    //public void UpMaxLife()
    //{
    //    Player.damage++;
    //}
    public void UseHealth()
    {
        Player.Life++;
    }

    public void Reload_Weapon()
    {
      
    }
    public GameObject MainCan;
    public GameObject CharCan;

    public GameObject Agility_Text;
    public GameObject MaxLife_Text;
    public GameObject Accuracy_Text;
    public GameObject Strange_Text;
    public GameObject Point_Text;

    public GameObject Life_Text;
    public GameObject Lvl_Text;
    public GameObject Weapon_Text;
    public GameObject Ammo_Text;
    public GameObject Count_Health;

    public GameObject Up_btn; 

    public void Update()
    {
        if (Player.points > 0)
            Up_btn.SetActive(true);
        else
            Up_btn.SetActive(false);

        Agility_Text.GetComponent<Text>().text = Player.agility.ToString();
        MaxLife_Text.GetComponent<Text>().text = Player.Max_Life.ToString();
        Accuracy_Text.GetComponent<Text>().text = Player.accuracy.ToString();
        Strange_Text.GetComponent<Text>().text = Player.strange.ToString();
        Point_Text.GetComponent<Text>().text = Player.points.ToString();

        Life_Text.GetComponent<Text>().text = Player.Life.ToString();
        Lvl_Text.GetComponent<Text>().text = Player.lvl.ToString();
        Count_Health.GetComponent<Text>().text = Player.Count_Health.ToString();
        Weapon_Text.GetComponent<Text>().text = Player.Type_Weapon;

        Ammo_Text.GetComponent<Text>().text = Player.cartridges.ToString();
    }

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
