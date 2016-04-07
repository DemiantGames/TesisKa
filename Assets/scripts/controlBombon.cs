using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class controlBombon : MonoBehaviour {


	private bool JumpFlag = false;
	private int dir=4;
	private Animator animator;
	private int puntos=0;
	public Text puntostext;
	private float TiempoparaIDLE =0.2f;
	void Start () {

		animator = GetComponent<Animator> ();


	}
	// Update is called once per frame
	void Update () {
		
		float moveInput = Input.GetAxis("Horizontal") * Time.deltaTime * 6;
	
		if (moveInput == 0) {
			if (TiempoparaIDLE<=0) {
				animator.SetBool ("Corriendo", false);
				TiempoparaIDLE = 0.2f;
			}
			TiempoparaIDLE -= Time.deltaTime;

		}else if (moveInput < 0) {
			dir = -4;

			animator.SetBool ("Corriendo", true);
		} else if(moveInput > 0) {
			dir = 4;
			animator.SetBool ("Corriendo", true);
		}
		transform.localScale = new Vector3 (dir, 4, 0);
		transform.position += new Vector3 (moveInput, 0, 0);

		if (Input.GetButtonDown ("Jump") && JumpFlag) {
			animator.SetTrigger ("Saltar");
			GetComponent<Rigidbody2D>().AddForce(new Vector3(0,400,0));

		} 


	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "Piso") {
			JumpFlag = true;
			animator.SetBool ("Piso", true);
		}
		if (col.gameObject.tag == "BuenaPalabra") {
			if(puntos<14){
			puntos += 1;
			puntostext.text = puntos.ToString ();
			}else {
					puntostext.text = "You Win";
				}

		}
		if (col.gameObject.tag == "MalaPalabra") {
			//Guardar la poscición de la pregunta para lanzarla después
		}
	}

	void OnCollisionExit2D(Collision2D col) {
		if (col.gameObject.tag == "Piso") {
			JumpFlag = false;
			animator.SetBool ("Piso", false);

		}

	}

}
