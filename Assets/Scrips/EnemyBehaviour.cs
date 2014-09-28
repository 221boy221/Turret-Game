using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {

    private float movementSpeed = 1 * Time.deltaTime;
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(0, -movementSpeed, 0);
	}
}
