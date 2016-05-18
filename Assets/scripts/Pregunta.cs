using UnityEngine;
using System.Collections;

public class Pregunta : MonoBehaviour {
	private float tiempo;
	// Use this for initialization
	void Start () {
		tiempo = 5;
	}
	
	// Update is called once per frame
	void Update () {
		if (tiempo <= 0) {
			Destroy (this.gameObject);
		}
		tiempo -= Time.deltaTime;
	}
}
