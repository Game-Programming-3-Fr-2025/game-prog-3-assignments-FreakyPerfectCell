using UnityEngine;

namespace PrototypeFour
{
    public class strange : MonoBehaviour
    {
        public int scoreValue = 1;

        private void OnMouseDown()
        {
            M.Instance.AddScore(scoreValue);
            Destroy(gameObject);
        }
    }
}
