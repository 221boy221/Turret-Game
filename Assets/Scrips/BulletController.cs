using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

    private float destroyTime = 1;
    [SerializeField] private float speed = 30;
    public float damage = 10;

    void Start() {
        Destroy(gameObject, destroyTime);
    }

    void Update() {
        this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
	
}
