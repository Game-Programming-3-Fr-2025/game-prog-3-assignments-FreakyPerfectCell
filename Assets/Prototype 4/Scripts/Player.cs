using UnityEngine;

namespace PrototypeSeven
{
    public class Player : MonoBehaviour
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
            input.y = Input.GetAxisRaw("Vertical");
            input.Normalize();

            if (input.x < 0)
            {
                sr.flipX = false;
            }
            else
            {
                sr.flipX = true;
            }
        }

        private void FixedUpdate()
        {
             rb.linearVelocity = input * speed; 
        }
    }
}
