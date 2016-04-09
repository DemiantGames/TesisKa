using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	private float TimeSpawn=5;
	private float tiempo=3;
	private int CantiPreguntas = 15, completelevel=0;
	public int NumPregunta=0,np=0;
	public int[] VectorPreguntas= new int[16];
	public controlBombon Bombon;
	public GameObject BuenaPalabra;
	public GameObject MalaPalabra;

	private Vector3 ubication1,ubication2,ubication3;
	public bool AlienComunica = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		AlienComunica = false;


		completelevel = 0;
		while(VectorPreguntas[NumPregunta]==1 && completelevel <=16){
			NumPregunta += 1;
			if (NumPregunta > 15) {
				NumPregunta = 0;
			}

			completelevel+=1;

		}


		if (tiempo <= 0 && completelevel<=16) {

			Spawn ();
			tiempo=TimeSpawn;
		}
		tiempo -= Time.deltaTime;





		if (Bombon.BienRespondido) {
			
			VectorPreguntas [np] = 1;
		} else {
			
			VectorPreguntas [np] = 0;
		}
		


	}

	void Spawn()
	{
		Bombon.BienRespondido = false;

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
		add1Pos*=3;
		add2Pos*=3;
		add3Pos*=3;



		ubication1 = transform.position + new Vector3 (add1Pos,0 , 0);
		ubication2 = transform.position + new Vector3 (add2Pos,0 , 0);
		ubication3 = transform.position + new Vector3 (add3Pos,0 , 0);




		if (NumPregunta <= CantiPreguntas) {
			
			if (NumPregunta == 0) {
				Instantiate (BuenaPalabra, ubication1, Quaternion.identity);
				Instantiate (MalaPalabra, ubication2, Quaternion.identity);
				Instantiate (MalaPalabra, ubication3, Quaternion.identity);
				//Instanceo Instantiate (Pregunta, new Vector3(0,0,0), Quaternion.identity);
			} else if (NumPregunta == 1) {
				Instantiate (BuenaPalabra, ubication1, Quaternion.identity);
				Instantiate (MalaPalabra, ubication2, Quaternion.identity);
				Instantiate (MalaPalabra, ubication3, Quaternion.identity);
				//Instanceo Instantiate (Pregunta, new Vector3(0,0,0), Quaternion.identity);
			} else if (NumPregunta == 2) {
				Instantiate (BuenaPalabra, ubication1, Quaternion.identity);
				Instantiate (MalaPalabra, ubication2, Quaternion.identity);
				Instantiate (MalaPalabra, ubication3, Quaternion.identity);
				//Instanceo Instantiate (Pregunta, new Vector3(0,0,0), Quaternion.identity);
			} else if (NumPregunta == 3) {
				Instantiate (BuenaPalabra, ubication1, Quaternion.identity);
				Instantiate (MalaPalabra, ubication2, Quaternion.identity);
				Instantiate (MalaPalabra, ubication3, Quaternion.identity);
				//Instanceo Instantiate (Pregunta, new Vector3(0,0,0), Quaternion.identity);
			} else if (NumPregunta == 4) {
				Instantiate (BuenaPalabra, ubication1, Quaternion.identity);
				Instantiate (MalaPalabra, ubication2, Quaternion.identity);
				Instantiate (MalaPalabra, ubication3, Quaternion.identity);
				//Instanceo Instantiate (Pregunta, new Vector3(0,0,0), Quaternion.identity);
			} else if (NumPregunta == 5) {
				Instantiate (BuenaPalabra, ubication1, Quaternion.identity);
				Instantiate (MalaPalabra, ubication2, Quaternion.identity);
				Instantiate (MalaPalabra, ubication3, Quaternion.identity);
				//Instanceo Instantiate (Pregunta, new Vector3(0,0,0), Quaternion.identity);
			} else if (NumPregunta == 6) {
				Instantiate (BuenaPalabra, ubication1, Quaternion.identity);
				Instantiate (MalaPalabra, ubication2, Quaternion.identity);
				Instantiate (MalaPalabra, ubication3, Quaternion.identity);
				//Instanceo Instantiate (Pregunta, new Vector3(0,0,0), Quaternion.identity);
			} else if (NumPregunta == 7) {
				Instantiate (BuenaPalabra, ubication1, Quaternion.identity);
				Instantiate (MalaPalabra, ubication2, Quaternion.identity);
				Instantiate (MalaPalabra, ubication3, Quaternion.identity);
				//Instanceo Instantiate (Pregunta, new Vector3(0,0,0), Quaternion.identity);
			} else if (NumPregunta == 8) {
				Instantiate (BuenaPalabra, ubication1, Quaternion.identity);
				Instantiate (MalaPalabra, ubication2, Quaternion.identity);
				Instantiate (MalaPalabra, ubication3, Quaternion.identity);
				//Instanceo Instantiate (Pregunta, new Vector3(0,0,0), Quaternion.identity);
			} else if (NumPregunta == 9) {
				Instantiate (BuenaPalabra, ubication1, Quaternion.identity);
				Instantiate (MalaPalabra, ubication2, Quaternion.identity);
				Instantiate (MalaPalabra, ubication3, Quaternion.identity);
				//Instanceo Instantiate (Pregunta, new Vector3(0,0,0), Quaternion.identity);
			} else if (NumPregunta == 10) {
				Instantiate (BuenaPalabra, ubication1, Quaternion.identity);
				Instantiate (MalaPalabra, ubication2, Quaternion.identity);
				Instantiate (MalaPalabra, ubication3, Quaternion.identity);
				//Instanceo Instantiate (Pregunta, new Vector3(0,0,0), Quaternion.identity);
			} else if (NumPregunta == 11) {
				Instantiate (BuenaPalabra, ubication1, Quaternion.identity);
				Instantiate (MalaPalabra, ubication2, Quaternion.identity);
				Instantiate (MalaPalabra, ubication3, Quaternion.identity);
				//Instanceo Instantiate (Pregunta, new Vector3(0,0,0), Quaternion.identity);
			} else if (NumPregunta == 12) {
				Instantiate (BuenaPalabra, ubication1, Quaternion.identity);
				Instantiate (MalaPalabra, ubication2, Quaternion.identity);
				Instantiate (MalaPalabra, ubication3, Quaternion.identity);
				//Instanceo Instantiate (Pregunta, new Vector3(0,0,0), Quaternion.identity);
			} else if (NumPregunta == 13) {
				Instantiate (BuenaPalabra, ubication1, Quaternion.identity);
				Instantiate (MalaPalabra, ubication2, Quaternion.identity);
				Instantiate (MalaPalabra, ubication3, Quaternion.identity);
				//Instanceo Instantiate (Pregunta, new Vector3(0,0,0), Quaternion.identity);
			} else if (NumPregunta == 14) {
				Instantiate (BuenaPalabra, ubication1, Quaternion.identity);
				Instantiate (MalaPalabra, ubication2, Quaternion.identity);
				Instantiate (MalaPalabra, ubication3, Quaternion.identity);
				//Instanceo Instantiate (Pregunta, new Vector3(0,0,0), Quaternion.identity);
			} else if (NumPregunta == 15) {
				Instantiate (BuenaPalabra, ubication1, Quaternion.identity);
				Instantiate (MalaPalabra, ubication2, Quaternion.identity);
				Instantiate (MalaPalabra, ubication3, Quaternion.identity);
				//Instanceo Instantiate (Pregunta, new Vector3(0,0,0), Quaternion.identity);
			} 

			AlienComunica = true;
		} 
		np = NumPregunta;
		NumPregunta += 1;

		if (NumPregunta > 15) {
			NumPregunta = 0;
		}





	}
}
