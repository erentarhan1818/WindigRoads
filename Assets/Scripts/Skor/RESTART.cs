using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RESTART : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("kolay orta zor");
    }
}                       
