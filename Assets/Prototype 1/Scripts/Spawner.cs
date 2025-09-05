using UnityEngine;

namespace PrototypeOne
{
    public class Spawner : MonoBehaviour
    {
        
        [SerializeField] private GameObject _bisonPrefab;
        [SerializeField] private float _minimumSpawnTime;
        [SerializeField] private float _maximumSpawnTime;
        private float _timeUntilSpawn;

        void Awake()
        {
            SetTimeUntilSpawn();
        }

        void Update()
        {
            _timeUntilSpawn -= Time.deltaTime;
            if (_timeUntilSpawn <= 0)
            {
                Instantiate(_bisonPrefab, transform.position, Quaternion.identity);
                SetTimeUntilSpawn();
            }
        }

        private void SetTimeUntilSpawn()
        {
            _timeUntilSpawn = Random.Range(_minimumSpawnTime, _maximumSpawnTime);
        }
    }
}
