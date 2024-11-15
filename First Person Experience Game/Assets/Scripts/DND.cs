using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DND : MonoBehaviour
{
   private static GameObject dndObject; 
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

    if (dndObject == null)
    {
        dndObject = this.gameObject;
    }
    else
    {
       Destroy(this.gameObject);
    }


    }

 
}
