using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    private float z = 0; // Угол на который повернуто орудие
    public float ammoForce = 600f;
    private float mSpeedGunRotate = 1.0f;
    //private float shotingRate = 0.5f;

    public GameObject ammo; // Снаряд

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Управление орудием
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            if (z < 90) z += mSpeedGunRotate;
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            if (z > -90) z -= mSpeedGunRotate;
        this.transform.rotation = Quaternion.Euler(0f, 0f, z);

        // Стрельба
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject g = Instantiate(ammo, GameObject.Find("Spawn").transform.position, transform.rotation);
            g.GetComponent<Rigidbody>().AddForce(transform.up * ammoForce);
        }
    }
}
