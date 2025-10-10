using UnityEngine;

namespace PrototypeFour
{
    public class RandomSpawner : MonoBehaviour
    {

        [SerializeField] public GameObject Prefab;        
        [SerializeField] private float minimumSpawnTime;
        [SerializeField] private float maximumSpawnTime;
        [SerializeField] private AudioClip spawn;
        private float timeUntilSpawn;
        public float Radius = 1;
        private AudioSource _audio;

        void Awake()
        {
            _audio = GetComponent<AudioSource>();
            SetTimeUntilSpawn();
        }

        void Update()
        {
            timeUntilSpawn -= Time.deltaTime;
            if (timeUntilSpawn <= 0)
            {
                Vector3 randomPos = Random.insideUnitCircle * Radius;
                Instantiate(Prefab, randomPos, Quaternion.identity);
                if (spawn != null && _audio != null)
                {
                    _audio.PlayOneShot(spawn);
                }
                SetTimeUntilSpawn();
            }
        }


        private void SetTimeUntilSpawn()
        {
            timeUntilSpawn = Random.Range(minimumSpawnTime, maximumSpawnTime);
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(this.transform.position, Radius);
        }
    }
}
