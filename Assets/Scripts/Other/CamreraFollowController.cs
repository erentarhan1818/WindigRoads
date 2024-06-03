using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CamreraFollowController : MonoBehaviour
{
    [SerializeField] private Transform ballTransform;

    private Vector3 offset;
    private Vector3 newPosition;


    [SerializeField] private float lerpValue;

    
    
    void Start()
    {
        offset = transform.position - ballTransform.position;
    }
    

    void LateUpdate()
    {
        SetCameraSmoothFollow();
    }


    private void SetCameraSmoothFollow()
    {
        newPosition = Vector3.Lerp(transform.position,ballTransform.position + offset, lerpValue *Time.deltaTime);
        transform.position = newPosition;
    }
    
 
}
