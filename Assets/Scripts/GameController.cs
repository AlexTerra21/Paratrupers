using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject Aeroplane;
    public GameObject[] ArraySpawnAeroplane;
    private float intensivity = 3.5f;
	// Use this for initialization
	void Start () {
        //mSpawnAeroplane = GameObject.Find("SpawnAeroplane");
        StartCoroutine(SpawnAeroplane());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator SpawnAeroplane()
    {
        while (true)
        {
            Instantiate(Aeroplane, ArraySpawnAeroplane[Random.Range(0, 2)].transform.position, new Quaternion(0, 0, 1, 1));
            Instantiate(Aeroplane, ArraySpawnAeroplane[Random.Range(2, 4)].transform.position, new Quaternion(0, 0, -1, 1));
            yield return new WaitForSeconds(intensivity);
        }
    }
}
