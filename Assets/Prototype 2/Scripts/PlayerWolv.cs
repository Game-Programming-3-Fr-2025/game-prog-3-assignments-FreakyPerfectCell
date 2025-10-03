using UnityEngine;

namespace PrototypeTwo
{
    public class PlayerWolv : MonoBehaviour
    {

        public float speed = 0.5f;
        private Rigidbody2D rb;
        private Vector2 input;
        private SpriteRenderer sr;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            sr = GetComponent<SpriteRenderer>();
        }

        void Update()
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.Normalize();

            if (input.x < 0)
            {
                sr.flipX = true;
            }
            else
            {
                sr.flipX = false;
            }
        }

        private void FixedUpdate()
        {
             rb.linearVelocity = input * speed; 
        }
    }
}
