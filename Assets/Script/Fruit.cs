using UnityEngine;
using System.Collections;

public class Fruit : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
		if (transform.position.y < -10) {
			Destroy (this.gameObject);
		}
	}
}
