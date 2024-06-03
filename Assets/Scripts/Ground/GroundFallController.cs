using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundFallController : MonoBehaviour   //ground fall controller  =  zemin d��me kontrol�.
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
   



    public IEnumerator SetRigidBodyValues()  //IEnumerator = say�c�.
    {
        yield return new WaitForSeconds(0.75f); //bu 3 sat�rl�k kod zeminin d��me h�z�n� ve ne zman d��ece�ini belirliyor.
        rb.isKinematic = false;
        rb.useGravity = true;
        
    }
}
