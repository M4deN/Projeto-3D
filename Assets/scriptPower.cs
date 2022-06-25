using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPower : MonoBehaviour
{
    public GameObject power;
    // Start is called before the first frame update
    void Start()
    {
        power = GetComponent<GameObject>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(this.gameObject);

            scriptPlacar.incrementarPlacar(1);
        }

    }
}
