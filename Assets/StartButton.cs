using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void BeginScene()
    {
        SceneManager.LoadScene(1);
        GetComponent<AudioSource>().Play();
    }
}
