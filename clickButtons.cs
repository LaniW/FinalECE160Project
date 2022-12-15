using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickButtons : MonoBehaviour
{
    private bool orangeB;
    private bool redB;
    private bool greenB;
    private int counter;
    private GameObject orangeButton;
    private GameObject redButton;
    private GameObject greenButton; 
    private GameObject yellowButton;
    private GameObject plantGone;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 4)
        {
            plantGone = GameObject.FindWithTag("multicolorPlant");
            plantGone.GetComponent<MeshRenderer>().enabled = false;
            plantGone.GetComponent<Collider>().enabled = false;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("orangeb"))
        {
            orangeB = true;
            if (counter == 0)
            {
                counter++;
                orangeButton.GetComponent<MeshRenderer>().enabled = false;
                orangeButton.GetComponent<Collider>().enabled = false;
                Destroy(orangeButton, 2);
            }
        }else if (col.gameObject.CompareTag("redb"))
        {
            redB = true;
            if (orangeB)
            {
                counter++;
                redButton.GetComponent<MeshRenderer>().enabled = false;
                redButton.GetComponent<Collider>().enabled = false;
                Destroy(redButton, 2);
            }
        }else if (col.gameObject.CompareTag("greenb"))
        {
            greenB = true;
            if (orangeB && redB)
            {
                counter++;
                greenButton.GetComponent<MeshRenderer>().enabled = false;
                greenButton.GetComponent<Collider>().enabled = false;
                Destroy(greenButton, 2);
            }
        }else if (col.gameObject.CompareTag("yellowb"))
        {
            if(orangeB && redB && greenB)
            {
                counter++;
                yellowButton.GetComponent<MeshRenderer>().enabled = false;
                yellowButton.GetComponent<Collider>().enabled = false;
                Destroy(yellowButton, 2);
            }
        }
    }
}
