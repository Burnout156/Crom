using UnityEngine;
using System.Collections;

public class movimento_personagem : MonoBehaviour {

	/*void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Inimigo")
		{
			Destroy(col.gameObject);
		}
	} */

	float vel = 2;
	public GameObject Parede;
    public GameObject Inimigo;
	Animator animacao;

	void Start () {
		animacao = GetComponent<Animator>();
	}
	

	void Update () {

		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (0, vel * Time.deltaTime, 0);
			if (Input.GetKey (KeyCode.F)) {
				Vector3 posicao = new Vector3 (0, 0, transform.position.y * 2);
				Instantiate (Parede, posicao, Quaternion.identity);
			}
		}

		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (-vel * Time.deltaTime, 0, 0);
			if (Input.GetKey (KeyCode.F)) {
				Vector3 posicao = new Vector3 (0, 0,transform.position.x / 2);
				Instantiate (Parede, posicao, Quaternion.identity);
			}
		}


		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (vel * Time.deltaTime, 0, 0);
			if (Input.GetKey (KeyCode.F)) {
				Vector3 posicao = new Vector3 (transform.position.x * 2, 0 );
				Instantiate (Parede, posicao, Quaternion.identity);
			}
		}

		if (Input.GetKey (KeyCode.S)) {
			transform.Translate(0,-vel * Time.deltaTime,0);
			if (Input.GetKey (KeyCode.F)) {
				Vector3 posicao = new Vector3 (0, transform.position.y / 2);
				Instantiate (Parede, posicao, Quaternion.identity);
			}
		}

		if (Input.GetKey (KeyCode.M)){
            animacao.Play("Martelada");
		
		}

	       if (Input.GetKey (KeyCode.F)) {
				Vector3 posicao = new Vector3 (transform.position.x * 2, 0);
				Instantiate (Parede, posicao, Quaternion.identity);
			} 
	}
}







		
