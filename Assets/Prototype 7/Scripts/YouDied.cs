using UnityEngine;
using UnityEngine.SceneManagement;

namespace PrototypeFive
{
    public class YouDied : MonoBehaviour
    {

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                ResetScene();
            }
        }

        void ResetScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
