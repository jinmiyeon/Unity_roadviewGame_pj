using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tomato : MonoBehaviour
{


    // Start is called before the first frame update
    public float speed = 15f;
    private Rigidbody BulletRigidbody;
    void Start()
    {
       BulletRigidbody = GetComponent<Rigidbody>();
      
        BulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3f);
    }
   

    // Update is called once per frame
    void Destroy(object obj)
    {

    }

    void Update()
    {

    }
}
