using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovementController : MonoBehaviour
{
    [SerializeField] private BallDataTransmiter ballDataTransmiter;

    [SerializeField] private float ballMoveSpeed;
    public float eklenecekhiz;
    public float hiz;

    private void Update()
    {
        SetBallMovement();

        if(Input.GetMouseButtonDown(0))   //her dokunmada yönü değişşin tek tıklama.
        {
            hiz += eklenecekhiz * Time.deltaTime;
        }
    }


    private void SetBallMovement()
    {
        transform.position += ballDataTransmiter.GetBallDirection() * ballMoveSpeed * Time.deltaTime;
    }
     
   


}
