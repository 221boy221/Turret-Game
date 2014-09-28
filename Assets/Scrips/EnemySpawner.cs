using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    [SerializeField] private GameObject gameObject;
    [SerializeField] private float enemies = 10;

	void Start () {
        SpawnEnemies();
	}

    void SpawnEnemies() {
        for (var i = 0; i < enemies; i++) {
            Instantiate(gameObject, new Vector3(Random.Range(-4f,4f), i*2 + 10, 0), Quaternion.identity);
        }
    }
	
}
