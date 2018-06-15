﻿namespace VRTK.Examples
{
    using UnityEngine;

    public class Dectected : VRTK_InteractableObject
    {
        public GameObject Canvas;
        float spinSpeed = 0f;
        Transform rotator;
       

        public override void StartUsing(VRTK_InteractUse usingObject)
        {
            base.StartUsing(usingObject);  
            Debug.Log(gameObject.name);
            Gun_Controller.Shoot = true;   
            
            //Canvas.GetComponent<Canvas>().enabled = false;
            
            //spinSpeed = 360f;
            //Canvas.GetComponent<Canvas>().enabled = false;
        }

        public override void StopUsing(VRTK_InteractUse usingObject)
        {
            base.StopUsing(usingObject);
            Gun_Controller.Shoot = false;
            //spinSpeed = 0f;
            //Canvas.GetComponent<Canvas>().enabled = true;
        }
        //private void OnTriggerEnter(Collider other)
        //{
        //    if(other.tag == "Bullet_gun")
        //    {
        //        Enemy.Win = true; 
        //    }
        //}
        //protected void Start()
        //{
        //    //rotator = transform.Find("Cube");
        //}

        //protected override void Update()
        //{
        //    base.Update();
        //    //rotator.transform.Rotate(new Vector3(spinSpeed * Time.deltaTime, 0f, 0f));
        //}
    }
}