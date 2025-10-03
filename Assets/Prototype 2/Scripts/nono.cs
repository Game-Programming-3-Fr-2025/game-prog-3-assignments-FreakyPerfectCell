using UnityEngine;

namespace PrototypeTwo
{
    public class nono : MonoBehaviour
    {
        public float speed = 10f;
        public Sprite newSprite;

        private SpriteRenderer spriteRenderer;
        private bool hasChangedSprite = false;

        void Start()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            Destroy(gameObject, 10f);
        }

        void Update()
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!hasChangedSprite && other.CompareTag("Player"))
            {
                if (spriteRenderer != null && newSprite != null)
                {
                    spriteRenderer.sprite = newSprite;
                    hasChangedSprite = true;
                }
            }
        }
    }
}
