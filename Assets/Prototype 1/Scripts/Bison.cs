using UnityEngine;

namespace PrototypeOne
{
    public class Bison : MonoBehaviour
    {

        public float speed;

        void Start()
        {

        }

        void Update()
        {
            GameObject player = GameObject.FindWithTag("Player");
            if (player != null)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                Destroy(gameObject);
            }
        }
    }
}
