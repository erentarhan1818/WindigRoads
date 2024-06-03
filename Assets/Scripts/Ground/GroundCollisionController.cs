using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisionController : MonoBehaviour
{
   
    [SerializeField ] private GroundDataTransmitter groundDataTransmitter; // seralizefeld  (inspector da) g�z�kmesini sa�l�yo

     private void OnCollisionExit(Collision other)
   {
    if(other.gameObject.CompareTag("Ball"))
    {
    Skor.skor++;
    groundDataTransmitter.SetGroundRigidbodyValues();
    }
   }
   
}
