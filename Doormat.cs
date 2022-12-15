using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doormat : MonoBehaviour
{
    public Rigidbody r;

    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if((collision.gameObject.tag == "lHand") && (collision.gameObject.tag == "rHand"))
        {
            Destroy(collision.gameObject);
        }
    }

}
