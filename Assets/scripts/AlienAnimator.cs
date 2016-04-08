using UnityEngine;
using System.Collections;

public class AlienAnimator : MonoBehaviour {
	private Animator animator;
	public Spawner spawner;
	public controlBombon bombon;


	void Start () {
		
		animator = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		
		if(spawner.AlienComunica){
			animator.SetTrigger ("Comunicar");
			//Aquí debe Instanciar la pregunta o Imagen
		}
	
		if(bombon.Error){
			animator.SetTrigger ("Error");

		}
	}
}
