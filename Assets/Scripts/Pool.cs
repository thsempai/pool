using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    public List<KimBehavior> kims = new List<KimBehavior>();
    public GameObject kimPrefab;
    // Start is called before the first frame update

    public KimBehavior Create(Vector3 position, Quaternion rotation) {

        KimBehavior kim = null;

        if(kims.Count > 0) {
            kim = kims[0];
            kims.RemoveAt(0);
            kim.transform.rotation = rotation;
            kim.transform.position = position;
            kim.gameObject.SetActive(true);
        }
        else {
            GameObject kimGo = Instantiate(kimPrefab, position, rotation);
            kim = kimGo.GetComponent<KimBehavior>();
        }

        return kim;
    }

    public void Kill(KimBehavior kim) {
        kim.gameObject.SetActive(false);
        kims.Add(kim);
    }

}
