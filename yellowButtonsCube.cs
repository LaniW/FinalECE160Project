using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowButtonsCube : MonoBehaviour
{

    private bool a;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (a)
        {
            a = false;
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
            Destroy(gameObject, 2);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("yellowBB"))
        {
            a = true;
        }
    }
}
