using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControle : MonoBehaviour {

    public Animator Anime;
    public Rigidbody2D PlayerRigidbody;
    public int forcaPulo;
    public bool pulo;
    public bool slide;
	public TextMesh Score;
	public int Coins;
	public int Quiz = 7;
	public AudioClip Coin;

    //Verifica o chaochao
    public Transform Verificarchao2;
    public bool chao;
    public LayerMask Oqueechao;

    //slide
    public float slideTemp;
    public float timeTemp;

    //colisor
    public Transform colisor;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		//se o botao pulo for apertado
        if(Input.GetButtonDown("Jump")&& chao == true){
            PlayerRigidbody.AddForce(new Vector2(0, forcaPulo));
            if(slide == true)
            {
                slide = false;
                colisor.position = new Vector3(colisor.position.x, colisor.position.y + 0.95f, colisor.position.z);
            }

        }
        if (Input.GetButtonDown("Slide") && chao == true && slide == false){
            colisor.position = new Vector3(colisor.position.x, colisor.position.y - 0.95f, colisor.position.z);
            slide = true;
            timeTemp = 0;


        }
        chao = Physics2D.OverlapCircle(Verificarchao2.position, 0.2f,Oqueechao);

        if(slide == true){

            timeTemp += Time.deltaTime;
            if(timeTemp >= slideTemp){

                colisor.position = new Vector3(colisor.position.x, colisor.position.y + 0.95f, colisor.position.z);
                slide = false;

            }

            }
        Anime.SetBool("Pular", !chao);
        Anime.SetBool("slider", slide);
    }
	void OnTriggerEnter2D(Collider2D col){

   //     Application.LoadLevel("Titulo2");

		if (col.gameObject.tag == "Box" || col.gameObject.tag == "Pedra" || col.gameObject.tag == "Tijolo" || col.gameObject.tag == "Vaso"   ) {

			if(Coins >= Quiz){
				Application.LoadLevel("Titulo2");
			} else Application.LoadLevel("gameover"); 
			
		} else if (col.gameObject.tag == "Coin" || col.gameObject.tag == "Mochila"  || col.gameObject.tag == "Lapis") {


			Coins++;
			Score.text = Coins + "";
		} 

        }
    
        
    }












