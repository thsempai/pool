using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Pool pool;
    public float delay = 1f;
    public Vector3 kimDestination;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn() {
        while (true) {
            KimBehavior kim = pool.Create(transform.position, transform.rotation);
            kim.destination = kimDestination;
            yield return new WaitForSeconds(delay);
        }
    } 
    
}
