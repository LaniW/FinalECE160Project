using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyUnlockDoor : MonoBehaviour
{

    private bool destroyKey;
    private GameObject whiteDoor;
    private GameObject knob;
    private GameObject handle;
    private GameObject redWall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (destroyKey)
        {
            destroyKey = false;
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
            Destroy(gameObject, 2);

            whiteDoor = GameObject.FindWithTag("chamferbox");
            whiteDoor.GetComponent<MeshRenderer>().enabled = false;
            whiteDoor.GetComponent<Collider>().enabled = false;
            knob = GameObject.FindWithTag("knob");
            knob.GetComponent<MeshRenderer>().enabled = false;
            knob.GetComponent<Collider>().enabled = false;
            handle = GameObject.FindWithTag("handle");
            handle.GetComponent<MeshRenderer>().enabled = false;
            handle.GetComponent<Collider>().enabled = false;
            redWall = GameObject.FindWithTag("redwall");
            redWall.GetComponent<Collider>().enabled = false;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("chamferbox"))
        {
            destroyKey = true;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<Collider>().enabled = false;
            Destroy(gameObject, 2);
        }
    }
}
