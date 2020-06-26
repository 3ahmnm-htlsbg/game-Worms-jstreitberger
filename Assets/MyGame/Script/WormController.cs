using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    
    public Rigidbody rb;
    public Vector3 x;
    public Vector3 y;
    public KeyCode jumpKey;
    public KeyCode downKey;
    public KeyCode forwardKey;
    public KeyCode backwardKey;
    public KeyCode shootKey;
    public ForceMode f;
    public GameObject projectile;
    public Vector3 position;
   




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(jumpKey))
        {
            Debug.Log("Sprungtaste wird gedrückt.");
            rb.AddForce(x, f);
        }

        if (Input.GetKeyDown(forwardKey))
        {
            Debug.Log("Charakter moves right.");
            rb.AddForce(y, f);
        }

        if (Input.GetKeyDown(backwardKey))
        {
            Debug.Log("Charakter moves left.");
            rb.AddForce(-y);
        }

        if (Input.GetKeyDown(downKey))
        {
            Debug.Log("Charakter moves down.");
            rb.AddForce(-x);
        }

     
      
    }
}
