using UnityEngine;

namespace PrototypeOne
{
    public class Player : MonoBehaviour
    {
        public float speed = 0.5f;
        private Rigidbody2D rb;
        private Vector2 input;
        private SpriteRenderer spriteRenderer;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");
            input.Normalize();
        }

        private void FixedUpdate()
        {
             rb.linearVelocity = input * speed; 
        }
    }
}
