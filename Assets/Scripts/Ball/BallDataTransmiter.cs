using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDataTransmiter : MonoBehaviour
{
    [SerializeField] private BallInputController ballInputController;



    public Vector3 GetBallDirection() //vector 3 3 boyutlu oyunlar için kullanýlýr yani (x,y,z).
    {
        return ballInputController.ballDirection;
    }
   

}
