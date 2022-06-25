using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class scriptNPC : MonoBehaviour
{
    private bool perseguicao = false;
    public float distMinWay = 10;
    public float distMinPC = 20;
    private int index = 0;
    public NavMeshAgent agente;
    public GameObject PC;
    public GameObject[] waypoints = new GameObject[7];
    public float distMin = 10;
    // Start is called before the first frame update

    void proximo()
    {
        agente.SetDestination(waypoints[index++].transform.position);
        
        if (index > 3)
            index = 0;
    }
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();

        proximo();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")

            Destroy(PC);

        else if (other.tag == "municao")

            Destroy(agente);
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, PC.transform.position) < distMinPC || perseguicao)
        {
            agente.SetDestination(PC.transform.position);
            perseguicao = true;
        }else
        {
            if (Vector3.Distance(transform.position, agente.destination) < distMinWay)
            {
                proximo();
            }
        }
        
   
    }
}
