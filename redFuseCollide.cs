using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redFuseCollide : MonoBehaviour
{

    private bool destroyHandCube;
    private GameObject doormat;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(destroyHandCube)
        {
            destroyHandCube = false;
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
            Destroy(gameObject, 2);

            doormat = GameObject.FindWithTag("Doormat");
            doormat.GetComponent<MeshRenderer>().enabled = false;
            doormat.GetComponent<Collider>().enabled = false;
            Destroy(doormat, 2);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("stuckRedCube"))
        {
           destroyHandCube = true;
            col.gameObject.GetComponent<MeshRenderer>().enabled = false;
            col.gameObject.GetComponent<Collider>().enabled = false;
            Destroy(col.gameObject, 2);
        }
    }
}
