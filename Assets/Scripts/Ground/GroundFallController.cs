using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundFallController : MonoBehaviour   //ground fall controller  =  zemin düþme kontrolü.
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
   



    public IEnumerator SetRigidBodyValues()  //IEnumerator = sayýcý.
    {
        yield return new WaitForSeconds(0.75f); //bu 3 satýrlýk kod zeminin düþme hýzýný ve ne zman düþeceðini belirliyor.
        rb.isKinematic = false;
        rb.useGravity = true;
        
    }
}
