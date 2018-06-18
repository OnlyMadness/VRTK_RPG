namespace VRTK.Examples
{
    using UnityEngine;

    public class Health_Controller_2 : VRTK_InteractableObject
    {
        public override void StartUsing(VRTK_InteractUse usingObject)
        {
            base.StartUsing(usingObject);      
        }

        protected void Start()
        {          
            
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.name == "[VRTK][AUTOGEN][HeadsetColliderContainer]")
            {
                if (gameObject.tag == "health1")
                {
                    Player.Life += 10;
                    Destroy(gameObject);
                }
                if (gameObject.tag == "health2")
                {
                    Player.Life += 30;
                    Destroy(gameObject);
                }
                if (gameObject.tag == "health3")
                {
                    Player.Life += 50;
                    Destroy(gameObject);
                }
            }
        }
        //protected override void Update()
        //{
        //    base.Update();
        //    gameObject.transform.rotation = GameObject.Find("[VRTK][AUTOGEN][RightController][BasePointerRenderer_Origin_Smoothed]").transform.rotation;
        //}
    }
}