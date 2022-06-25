using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCamera : MonoBehaviour
{
    public float velRot = 200;

    private float rotX = 0;
    private Quaternion rotInicial;
   
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        rotInicial = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {


        rotX = rotX + Input.GetAxisRaw("Mouse Y") * Time.deltaTime * velRot;

        rotX = Mathf.Clamp(rotX, -60, 60);
        Quaternion rotCB = Quaternion.AngleAxis(rotX, Vector3.left);

        transform.localRotation = rotInicial * rotCB;
    }
}
