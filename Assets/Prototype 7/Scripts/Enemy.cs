using UnityEngine;
using UnityEngine.UI;

namespace PrototypeFive
{
    public class Enemy : MonoBehaviour
    {

        public GameObject deadScreen;
        public float speed;

        void Start()
        {
            deadScreen.SetActive(false);
        }

        void Awake()
        {
            deadScreen.SetActive(false);
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
                deadScreen.SetActive(true);
            }
        }
    }
}
