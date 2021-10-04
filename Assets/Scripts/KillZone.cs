using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public Pool pool;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        KimBehavior kim = other.GetComponent<KimBehavior>();
        if(kim != null) {
           pool.Kill(kim);
        }
    }
}
