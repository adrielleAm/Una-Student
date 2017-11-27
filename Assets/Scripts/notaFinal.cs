using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class notaFinal : MonoBehaviour {

	private int idTema = 0;

	public Text txtNota;
	public Text txtInfoTema;

	public GameObject estrela1;
	public GameObject estrela2;
	public GameObject estrela3;

	private int notaF;
	private int acertos;

	// Use this for initialization
	void Start () {

		estrela1.SetActive (false);
		estrela2.SetActive (false);
		estrela3.SetActive (false);

		idTema = PlayerPrefs.GetInt ("idTema");
		notaF = PlayerPrefs.GetInt ("notaFinalTemp" + idTema.ToString ());
		acertos = PlayerPrefs.GetInt ("acertosTemp" + idTema.ToString ());

		txtNota.text = notaF.ToString ();
		txtInfoTema.text = "Voce acertou " + acertos.ToString () + " de 2 questoes.";

		if (notaF == 10) {
			estrela1.SetActive (true);
			estrela2.SetActive (true);
			estrela3.SetActive (true);
		} else if (notaF >= 5) {
			estrela1.SetActive (true);
			estrela2.SetActive (true);
			estrela3.SetActive (false);
		}else if (notaF < 5 && notaF > 0) {
			estrela1.SetActive (true);
			estrela2.SetActive (false);
			estrela3.SetActive (false);
		}

	}

	public void jogarNovamente(){
		Application.LoadLevel ("T" + idTema.ToString ());
	}

}











