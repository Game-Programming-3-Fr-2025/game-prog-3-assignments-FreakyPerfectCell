using UnityEngine;

namespace PrototypeThree
{
    public class Gun : MonoBehaviour
    {
        private Rigidbody2D rb;
        public Transform Aim;
        public GameObject bullet;
        public float fireForce = 10f;
        float shootCooldown = 0.25f;
        float shootTimer = 0.5f;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            shootTimer += Time.deltaTime;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                OnShoot();
            }
        }

        void OnShoot()
        {
            if (shootTimer > shootCooldown)
            {
                shootTimer = 0;
                GameObject intBullet = Instantiate(bullet, Aim.position, Aim.rotation);
                intBullet.GetComponent<Rigidbody2D>().AddForce(-Aim.up * fireForce, ForceMode2D.Impulse);
                Destroy(intBullet, 2f);
            }
        }
    }
}
