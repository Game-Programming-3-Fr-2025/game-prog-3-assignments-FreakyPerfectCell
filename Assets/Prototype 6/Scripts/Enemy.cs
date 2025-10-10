using UnityEngine;

namespace PrototypeThree
{
    public class Enemy : MonoBehaviour
    {

        public float moveSpeed = 1f;
        Rigidbody2D rb;
        Transform target;
        Vector2 moveDirection;

        public float health, maxHealth = 100f;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void Start()
        {
            target = GameObject.Find("Player").transform;
            health = maxHealth;
        }

        void Update()
        {
            if (target)
            {
                Vector3 direction = (target.position - transform.position).normalized;
                moveDirection = direction;
            }
        }

        private void FixedUpdate()
        {
            if (target)
            {
                rb.linearVelocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
            }
        }

        public void TakeDamage(float damage)
        {
            health -= damage;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
