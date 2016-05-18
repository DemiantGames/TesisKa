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
	public GameObject[] Pregunta= new GameObject[15];
	public GameObject[] Respuesta= new GameObject[45];
//	public GameObject Pregunta1;
//	public GameObject Pregunta2;
//	public GameObject Pregunta3;
//	public GameObject Pregunta4;
//	public GameObject Pregunta5;

	private Vector3 ubication1, ubication2, ubication3, ubicationPregunta= new Vector3(5,0,0);
	public bool AlienComunica = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		AlienComunica = false;


		completelevel = 0;
		while(VectorPreguntas[NumPregunta]==1 && completelevel <=15){
			NumPregunta += 1;
			if (NumPregunta > 14) {
				NumPregunta = 0;
			}

			completelevel+=1;

		}


		if (tiempo <= 0 && completelevel<=15) {

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
				Instantiate (Pregunta[0], ubicationPregunta, Quaternion.identity);
				Instantiate (Respuesta[0], ubication1, Quaternion.identity);
				Instantiate (Respuesta[1], ubication2, Quaternion.identity);
				Instantiate (Respuesta[2], ubication3, Quaternion.identity);

			} else if (NumPregunta == 1) {
				Instantiate (Pregunta[1], ubicationPregunta, Quaternion.identity);
				Instantiate (Respuesta[3], ubication1, Quaternion.identity);
				Instantiate (Respuesta[4], ubication2, Quaternion.identity);
				Instantiate (Respuesta[5], ubication3, Quaternion.identity);

			} else if (NumPregunta == 2) {
				Instantiate (Pregunta[2], ubicationPregunta, Quaternion.identity);
				Instantiate (Respuesta[6], ubication1, Quaternion.identity);
				Instantiate (Respuesta[7], ubication2, Quaternion.identity);
				Instantiate (Respuesta[8], ubication3, Quaternion.identity);

			} else if (NumPregunta == 3) {
				Instantiate (Pregunta[3], ubicationPregunta, Quaternion.identity);
				Instantiate (Respuesta[9], ubication1, Quaternion.identity);
				Instantiate (Respuesta[10], ubication2, Quaternion.identity);
				Instantiate (Respuesta[11], ubication3, Quaternion.identity);

			} else if (NumPregunta == 4) {
				Instantiate (Pregunta[4], ubicationPregunta, Quaternion.identity);
				Instantiate (Respuesta[12], ubication1, Quaternion.identity);
				Instantiate (Respuesta[13], ubication2, Quaternion.identity);
				Instantiate (Respuesta[14], ubication3, Quaternion.identity);

			} else if (NumPregunta == 5) {
				Instantiate (Pregunta[5], ubicationPregunta, Quaternion.identity);
				Instantiate (Respuesta[15], ubication1, Quaternion.identity);
				Instantiate (Respuesta[16], ubication2, Quaternion.identity);
				Instantiate (Respuesta[17], ubication3, Quaternion.identity);

			} else if (NumPregunta == 6) {
				Instantiate (Pregunta[6], ubicationPregunta, Quaternion.identity);
				Instantiate (Respuesta[18], ubication1, Quaternion.identity);
				Instantiate (Respuesta[19], ubication2, Quaternion.identity);
				Instantiate (Respuesta[20], ubication3, Quaternion.identity);

			} else if (NumPregunta == 7) {
				Instantiate (Pregunta[7], ubicationPregunta, Quaternion.identity);
				Instantiate (Respuesta[21], ubication1, Quaternion.identity);
				Instantiate (Respuesta[22], ubication2, Quaternion.identity);
				Instantiate (Respuesta[23], ubication3, Quaternion.identity);

			} else if (NumPregunta == 8) {
				Instantiate (Pregunta[8], ubicationPregunta, Quaternion.identity);
				Instantiate (Respuesta[24], ubication1, Quaternion.identity);
				Instantiate (Respuesta[25], ubication2, Quaternion.identity);
				Instantiate (Respuesta[26], ubication3, Quaternion.identity);

			} else if (NumPregunta == 9) {
				Instantiate (Pregunta[9], ubicationPregunta, Quaternion.identity);
				Instantiate (Respuesta[27], ubication1, Quaternion.identity);
				Instantiate (Respuesta[28], ubication2, Quaternion.identity);
				Instantiate (Respuesta[29], ubication3, Quaternion.identity);

			} else if (NumPregunta == 10) {
				Instantiate (Pregunta[10], ubicationPregunta, Quaternion.identity);
				Instantiate (Respuesta[30], ubication1, Quaternion.identity);
				Instantiate (Respuesta[31], ubication2, Quaternion.identity);
				Instantiate (Respuesta[32], ubication3, Quaternion.identity);

			} else if (NumPregunta == 11) {
				Instantiate (Pregunta[11], ubicationPregunta, Quaternion.identity);
				Instantiate (Respuesta[33], ubication1, Quaternion.identity);
				Instantiate (Respuesta[34], ubication2, Quaternion.identity);
				Instantiate (Respuesta[35], ubication3, Quaternion.identity);

			} else if (NumPregunta == 12) {
				Instantiate (Pregunta[12], ubicationPregunta, Quaternion.identity);
				Instantiate (Respuesta[36], ubication1, Quaternion.identity);
				Instantiate (Respuesta[37], ubication2, Quaternion.identity);
				Instantiate (Respuesta[38], ubication3, Quaternion.identity);

			} else if (NumPregunta == 13) {
				Instantiate (Pregunta[13], ubicationPregunta, Quaternion.identity);
				Instantiate (Respuesta[39], ubication1, Quaternion.identity);
				Instantiate (Respuesta[40], ubication2, Quaternion.identity);
				Instantiate (Respuesta[41], ubication3, Quaternion.identity);

			} else if (NumPregunta == 14) {
				Instantiate (Pregunta[14], ubicationPregunta, Quaternion.identity);
				Instantiate (Respuesta[42], ubication1, Quaternion.identity);
				Instantiate (Respuesta[43], ubication2, Quaternion.identity);
				Instantiate (Respuesta[44], ubication3, Quaternion.identity);

			} 

			AlienComunica = true;
		} 
		np = NumPregunta;
		NumPregunta += 1;

		if (NumPregunta > 14) {
			NumPregunta = 0;
		}





	}
}
