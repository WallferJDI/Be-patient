using System.Collections;

using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPositions;
    [SerializeField] private Enemy _enemy;


    void Start() 
    {
        StartCoroutine(SpawnWave());
    }

    IEnumerator SpawnWave()
    {
        while (true)
        {
            for (int i = 0; i < _spawnPositions.Length; i++)
            {
                Instantiate(_enemy, _spawnPositions[i].position, Quaternion.identity);
                yield return new WaitForSeconds(1);

            }
        }

    }

   
}
