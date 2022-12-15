using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxInFuse : MonoBehaviour
{

    private bool showCube;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(showCube)
        {
            showCube = false;
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
            Destroy(gameObject.GetComponent<Collider>(), 2);
        }
    }

    void onCollisionEnter(Collision col)
    {
        if(col.collider.CompareTag("stuckRedCube"))
        {
            showCube = true;
        }
    }
}
