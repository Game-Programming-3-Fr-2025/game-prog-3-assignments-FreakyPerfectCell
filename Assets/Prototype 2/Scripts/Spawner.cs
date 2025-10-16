using UnityEngine;

namespace PrototypeTwo
{
    public class Spawner : MonoBehaviour
    {
        public GameObject prefabToSpawn;
        public float spawnDelay = 2f;

        private void Start()
        {
            InvokeRepeating("SpawnPrefab", spawnDelay, spawnDelay);
        }

        private void SpawnPrefab()
        {
            if (prefabToSpawn != null)
            {
                Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
            }
        }
    }
}
