using UnityEngine;

namespace PrototypeThree
{
    public class Robo : MonoBehaviour
    {
        public float speed = 0.5f;
        private Rigidbody2D rb;
        private Vector2 input;
        private SpriteRenderer sr;
        private Vector2 lastMoveDirection;

        public Transform Aim;
        bool isWalking = false;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            sr = GetComponent<SpriteRenderer>();
        }

        void Update()
        {
            Inputs();

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
             if (isWalking)
             {
                 Vector3 vector3 = Vector3.left * input.x + Vector3.down * input.y;
                 Aim.rotation = Quaternion.LookRotation(Vector3.forward, vector3);
             }
        }

        void Inputs()
        {
            float moveX = Input.GetAxisRaw("Horizontal");
            float moveY = Input.GetAxisRaw("Vertical");

            if ((moveX == 0 && moveY == 0) && (input.x == 0 || input.y == 0))
            {
                isWalking = false;
                lastMoveDirection = input;
                Vector3 vector3 = Vector3.left * lastMoveDirection.x + Vector3.down * lastMoveDirection.y;
                Aim.rotation = Quaternion.LookRotation(Vector3.forward, vector3);
            }
            else if (moveX != 0 || moveY != 0)
            {
                isWalking = true;
            }

            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");
            input.Normalize();
        }
    }
}
