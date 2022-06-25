using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPilulas : MonoBehaviour
{
    public GameObject pi;
    // Start is called before the first frame update
    void Start()
    {
        pi = GetComponent<GameObject>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);

            scriptPlacar.incrementarPlacar(10);
        }
    }
}
