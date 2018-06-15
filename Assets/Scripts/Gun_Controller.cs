namespace VRTK.Examples
{
    using UnityEngine;

    public class Gun_Controller : VRTK_InteractableObject
    {
        private GameObject bullet;
        private float bulletSpeed = 1000f;
        private float bulletLife = 5f;
        public static bool Shoot;
        public override void StartUsing(VRTK_InteractUse usingObject)
        {
            base.StartUsing(usingObject);
            FireBullet();
        }

        protected void Start()
        {          
            bullet = transform.Find("Bullet").gameObject;
            bullet.SetActive(false);
        }

        private void FireBullet()
        {
            if (Shoot&&Player.Battle&&Player.Stroke_player) { 
                GameObject bulletClone = Instantiate(bullet, bullet.transform.position, bullet.transform.rotation) as GameObject;
                bulletClone.SetActive(true);
                Rigidbody rb = bulletClone.GetComponent<Rigidbody>();
                rb.AddForce(-bullet.transform.forward * bulletSpeed);
                Destroy(bulletClone, bulletLife);        
            }
        }
        //protected override void Update()
        //{
        //    base.Update();
        //    gameObject.transform.rotation = GameObject.Find("[VRTK][AUTOGEN][RightController][BasePointerRenderer_Origin_Smoothed]").transform.rotation;
        //}
    }
}