using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class TurretBehaviour : MonoBehaviour {
    
    [SerializeField]
    private GameObject bulletPrefab;
    private Transform mainTarget;
    private float nextFireTime = 1;
    private float fireRate = 0.2f;
    private List<GameObject> enemyList = new List<GameObject>();
    
	
	void Update () {

        for (int i = 0; i < enemyList.Count; i++) {
            if (enemyList[i] == null) {
                enemyList.Remove(null);
            }
        }

        if (enemyList.Count > 0) {
            this.transform.LookAt(enemyList[0].gameObject.transform);
            if (Time.time > nextFireTime) {
                ShootBullet();
                nextFireTime = Time.time + fireRate;
            }
        }
	}

    void ShootBullet() {
        Instantiate(bulletPrefab,transform.position,transform.rotation);
    }

    void OnTriggerEnter2D(Collider2D target) {
        if (target.gameObject.tag == "Enemy") {
            enemyList.Add(target.gameObject);
        }
    }

    void OnTriggerExit2D(Collider2D target) {
        if (target.gameObject.tag == "Enemy") {
            enemyList.Remove(target.gameObject);
        }
    }

}
