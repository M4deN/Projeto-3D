using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class scriptPC : MonoBehaviour
{
    private Rigidbody rbd;
    public float velocidade = 10;
    public float velRot = 100;
    public GameObject esp;
    private float rotY = 0;
    private Quaternion rotInicial;
    private AudioSource som;
    public LayerMask mascara;
    private int municao = 0;
    public NavMeshAgent agente;

    // Start is called before the first frame update
    void Start()
    {
        rotInicial = transform.localRotation;
        rbd = GetComponent<Rigidbody>();
        som = GetComponent<AudioSource>();
        agente = GetComponent<NavMeshAgent>();
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "esp")

            rbd.transform.localPosition = new Vector3(15, -3, -139);

        else if (other.tag == "espelho")

            rbd.transform.localPosition = new Vector3(12, -3, 34);

        else if (other.tag == "municao")
        {
            municao += 5;

            Destroy(agente);

        }      

    }   
        // Update is called once per frame
        void Update()
        {
            float moveFrente = Input.GetAxis("Vertical");
            float moveLado = Input.GetAxis("Horizontal");

            rotY = rotY + Input.GetAxisRaw("Mouse X") * Time.deltaTime * velRot;

            Quaternion rotLado = Quaternion.AngleAxis(rotY, Vector3.up);

            transform.localRotation = rotInicial * rotLado;

            rbd.velocity = transform.TransformDirection(new Vector3(moveLado * velocidade, rbd.velocity.y, moveFrente * velocidade));

            if (municao > 0 && (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)))
            {            
                som.Play();
                RaycastHit hit;
                municao -=1;

            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 100, mascara))
                {
                    Collider tabua = hit.collider;
                    Rigidbody rbdCollider = tabua.GetComponent<Rigidbody>();
                    
                }
            }
        }
    }

