namespace VRTK.Examples
{
    using UnityEngine;

    public class Controller_cartridges : VRTK_InteractableObject
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
          //  if (other.name == "[VRTK][AUTOGEN][BodyColliderContainer]")
            if (other.name == "[VRTK][AUTOGEN][HeadsetColliderContainer]")
            {
                if (gameObject.tag == "cartridges")
                {
                    Player.cartridges += 10;
                    Destroy(gameObject);
                }
            }
        }
    }
}