using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	private float TimeSpawn=3;
	private float tiempo=3;
	public GameObject BuenaPalabra;
	public GameObject MalaPalabra;
	private Vector3 ubication1,ubication2,ubication3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {




		if (tiempo <= 0) {

			Spawn ();
			tiempo=TimeSpawn;
		}
		TimeSpawn -= Time.deltaTime;

	
	}

	void Spawn()
	{
		float add1Pos = Random.Range (0.51f,3.49f);
		add1Pos = Mathf.Round (add1Pos);
		float add2Pos = add1Pos + 1;
		if (add2Pos > 3) {
			add2Pos = 1;
		}
		float add3Pos = add2Pos + 1;
		if (add3Pos > 3) {
			add3Pos = 1;
		}
		add1Pos*=4;
		add2Pos*=4;
		add3Pos*=4;


		ubication1 = transform.position + new Vector3 (add1Pos,0 , 0);
		ubication2 = transform.position + new Vector3 (add2Pos,0 , 0);
		ubication3 = transform.position + new Vector3 (add3Pos,0 , 0);


		Instantiate (BuenaPalabra, ubication1, Quaternion.identity);
		Instantiate (MalaPalabra, ubication2, Quaternion.identity);
		Instantiate (MalaPalabra, ubication3, Quaternion.identity);
	}
}
