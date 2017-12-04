using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DR_AI_KillTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Kill Volume")
        {
            Object.Destroy(gameObject);
            print("Object killed");
        }
    }
}
