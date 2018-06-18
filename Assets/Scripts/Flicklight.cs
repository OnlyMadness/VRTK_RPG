using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicklight : MonoBehaviour {

    public Light Flick;
    public GameObject Lamp;

    private void Start()
    {
        Flick.enabled = false;
    }

    private void Update()
    {
        var RandomNumber = Random.value;


        if (RandomNumber <= .05)
        {
            Flick.enabled = true;
            Lamp.SetActive(true);
        }
        else {
            if (RandomNumber <= .2)
            {
                Flick.enabled = false;
                Lamp.SetActive(false);
            }
        }

    }


}
