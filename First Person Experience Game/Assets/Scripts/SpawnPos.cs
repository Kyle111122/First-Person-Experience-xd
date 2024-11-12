using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPos : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        if (GameObject.Find("Player").GetComponent<PlayerController>().spawnPoint == gameObject.name)
        {
            StartCoroutine(GameObject.Find("Player").GetComponent<PlayerController>().ResetPos());
        }
    }

}
