using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{

    public KeyCode jumpKey;

    public KeyCode forwardKey;

    public KeyCode backwardKey;

    public Vector3 v;

    public Vector3 y;

    public Rigidbody z;

    public Vector3 x;

    public ForceMode f;



 

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
            Debug.Log("die ForwardTaste wird gedrückt.");
            z.AddForce(y, f);

       
        }

        if (Input.GetKeyDown(backwardKey))
        {
            Debug.Log("die ForwardTaste wird gedrückt.");
            z.AddForce(v, f);


        }

    }
}
