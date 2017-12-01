using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DR_AI_KillTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Kill Volume")
        {
            Destroy(gameObject);
            print("Object killed");
        }
    }
}
