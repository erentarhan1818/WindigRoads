using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallBurningController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball") 
        {
            SceneManager.LoadScene(1);
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
}
