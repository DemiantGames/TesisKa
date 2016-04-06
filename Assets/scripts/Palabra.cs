using UnityEngine;
using System.Collections;

public class Palabra : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll) {
		Destroy (gameObject);

	}
}
