using UnityEngine;

namespace PrototypeSeven
{
    public class cChild : MonoBehaviour
    {

    private SpriteRenderer sr;
    public Sprite newSprite;
    private bool hasChanged = false;
    public Vector3 newSize = new Vector3(.2f, .2f, 1f);

        void Start()
        {
            sr = GetComponent<SpriteRenderer>();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!hasChanged && other.CompareTag("Player"))
            {
                if (sr != null && newSprite != null)
                {
                    sr.sprite = newSprite;
                    transform.localScale = newSize;
                    hasChanged = true;
                }
            }
        }
    }
}
