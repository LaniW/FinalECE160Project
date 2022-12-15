using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkIfDestroyed : MonoBehaviour
{
    private GameObject mPlant;
    public Rigidbody rr;
    private bool destroyPlant;

    // Start is called before the first frame update
    void Start()
    {
        rr = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (destroyPlant)
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
            Destroy(mPlant, 2);
        }
    }

    void onCollisionEnter(Collision col)
    {
        destroyPlant = true;
        if ((col.gameObject.tag == "lHand") && (col.gameObject.tag == "rHand"))
        {
            Destroy(col.gameObject);
        }
    }
}
