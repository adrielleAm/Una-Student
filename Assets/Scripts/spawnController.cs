using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnController : MonoBehaviour {
    public GameObject barreiraPrefab; //OBJETO A SER SPAWNADO
    public float rateSpawn; //intervado de spawn
    public float currentTime;
    private int posicao;
    private float y;
    public float posA;
    public float posB;
	public List<GameObject> Obstaculos;
    


	// Use this for initialization
	void Start () {

        currentTime = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
        currentTime += Time.deltaTime;
        if(currentTime >= rateSpawn)
        {
            currentTime = 0;
            posicao = Random.Range(1, 100);
            if(posicao > 50)
            {
                y = posA;
            }
            else
            {
                y = posB;

            }
         //   GameObject tempPrefab = Instantiate(barreiraPrefab)as GameObject;
          //  tempPrefab.transform.position = new Vector3(transform.position.x, y, tempPrefab.transform.position.z);

			GameObject tempPrefab = Instantiate(Obstaculos[Random.Range(0,7)])as GameObject;
			tempPrefab.transform.position = new Vector3(transform.position.x, y, tempPrefab.transform.position.z);




        }


	}
}
