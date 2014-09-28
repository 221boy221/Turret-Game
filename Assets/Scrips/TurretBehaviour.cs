using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class TurretBehaviour : MonoBehaviour {
    
    [SerializeField]
    private GameObject bulletPrefab;
    private float nextFireTime = 1;
    private float fireRate = 0.2f;
    private List<GameObject> enemyList = new List<GameObject>();

	void Update () {
        // Remove nulls from the list
        for (int i = 0; i < enemyList.Count; i++) {
            if (enemyList[i] == null) {
                enemyList.Remove(null);
            }
        }

        // Look at enemy
        if (enemyList.Count > 0) {
            enemyList.Sort();
            this.transform.LookAt(enemyList[0].gameObject.transform);
            // Shoot
            if (Time.time > nextFireTime) {
                ShootBullet();
                nextFireTime = Time.time + fireRate;
            }
        }
	}

    void ShootBullet() {
        Instantiate(bulletPrefab,transform.position,transform.rotation);
    }

    // When enemy is in range
    void OnTriggerEnter2D(Collider2D target) {
        if (target.gameObject.tag == "Enemy") {
            enemyList.Add(target.gameObject);
        }
    }
    // When enemy is out of range
    void OnTriggerExit2D(Collider2D target) {
        if (target.gameObject.tag == "Enemy") {
            enemyList.Remove(target.gameObject);
        }
    }

}
