using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aeroplane : MonoBehaviour
{

    private float speed = 3f;

    public GameObject blow;
    // Use this for initialization
    void Start()
    {
        DestroyObject(gameObject, 15f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        DestroyObject(Instantiate(blow, transform.position, Quaternion.identity), 2f);
        DestroyObject(gameObject);
        DestroyObject(collision.gameObject);

    }
}
