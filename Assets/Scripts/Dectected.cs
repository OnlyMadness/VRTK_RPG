namespace VRTK.Examples
{
    using UnityEngine;
    using UnityEngine.UI;

    public class Dectected : VRTK_InteractableObject
    {
        public GameObject Canvas;
        float spinSpeed = 0f;
        Transform rotator;


        public override void StartUsing(VRTK_InteractUse usingObject)
        {
            base.StartUsing(usingObject);
            Debug.Log(gameObject.name);
            if (Player.Battle)
            {
                if (gameObject.tag == "Head")
                {
                    Canvas.SetActive(true);
                    Canvas.transform.Find("TargetEmeny").GetComponent<Text>().text = "Голова";
                    Player.Shoot = true;
                }
                if (gameObject.tag == "Limbs")
                {
                    Canvas.SetActive(true);
                    Player.Shoot = true;
                    Canvas.transform.Find("TargetEmeny").GetComponent<Text>().text = "Конечность";
                    // GameObject.FindWithTag("TargetEmeny").

                }
                if (gameObject.tag == "Torso")
                {
                    Player.Shoot = true;
                    Canvas.transform.Find("TargetEmeny").GetComponent<Text>().text = "Туловище";
                    Canvas.SetActive(true);
                }
            }
            //Canvas.GetComponent<Canvas>().enabled = false;

            //spinSpeed = 360f;

        }

        public override void StopUsing(VRTK_InteractUse usingObject)
        {
            base.StopUsing(usingObject);
            Player.Shoot = false;
            Canvas.SetActive(false);

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
        ////{
        ////    

        ////base.Update();
        ////    //rotator.transform.Rotate(new Vector3(spinSpeed * Time.deltaTime, 0f, 0f));
        //}
    }
}