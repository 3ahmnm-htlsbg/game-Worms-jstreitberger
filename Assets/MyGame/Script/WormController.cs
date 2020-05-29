using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{

    public KeyCode jumpKey;

    public KeyCode downKey;

    public KeyCode forwardKey;

    public KeyCode backwardKey;

    public KeyCode shootKey;

    public Rigidbody z;

    public Vector3 position;

    public Vector3 y;

    public Vector3 x;

    public ForceMode f;

    public GameObject projectile;

    public Transform pos;

    public Quaternion quat;



 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(jumpKey))
        {
            //dieser Code wird ausgeführt, sobald die in der Variable jumpkey definierte Taste gedrückt wird
            Debug.Log("die JumpTaste wird gedrückt.");
            z.AddForce(x, f);
        }

      

        if (Input.GetKeyDown(forwardKey))
        {
            Debug.Log("Character bewegt sich vorwärts.");
            z.AddForce(y, f);

       
        }

        if (Input.GetKeyDown(backwardKey))
        {
            Debug.Log("Characktar bewegt sich zurück");
            z.AddForce(-y);
            
        }


        if (Input.GetKeyDown(downKey))
        {
            Debug.Log("Character bewegt sich nach unten.");
            z.AddForce(-x);


        }



        if (Input.GetKeyDown(shootKey))
        {
            Debug.Log("Character schießt.");
            Instantiate(projectile, position, quat);


        }



    }
}
