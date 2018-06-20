using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject Canvas;
    public static bool Limbs; 

    public void TriggerCanvas()
    {
        //Canvas.SetActive(false);
        Canvas.GetComponent<Canvas>().enabled = false ;
    }

	// Use this for initialization
	void Start () {
        //Canvas.GetComponent<Canvas>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		//if (Limbs)
  //      {
  //          Canvas.GetComponent<Canvas>().enabled = false;
  //      }
  //      else
  //      {
  //          Canvas.GetComponent<Canvas>().enabled = true;
  //      }
	}
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
