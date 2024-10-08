using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    public Collider triggerColl;

    GameManager gmSc; 


    // Start is called before the first frame update
    void Start()
    {
        gmSc = GameObject.Find("GameManager").GetComponent<GameManager>();
        gmSc.infoText.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void OnTriggerEnter(Collider other)
    {
        triggerColl = other; 

        if (other.gameObject.CompareTag("Key"))
        {
            gmSc.hasKey = true; 
            Destroy(other.gameObject);
        }

    if (other.gameObject.CompareTag("Lock"))
    {
       if (gmSc.hasKey) 
    {
        gmSc.infoText.text = "Press E To Interact";
    }
    else
    {
        gmSc.infoText.text = "You need a key to open this";
    }


    }

    if(other.gameObject.CompareTag("Lever"))
    {
        gmSc.infoText.text = "Press E To Switch";
    }








    }

}
