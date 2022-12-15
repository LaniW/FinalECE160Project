using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantController : MonoBehaviour
{

    private bool destroyPlant;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(destroyPlant)
        {
            destroyPlant = false;
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
            Destroy(gameObject, 2);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        destroyPlant = true;
    }
}
