using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelPortal : MonoBehaviour
{
    //public variables editable in Unity
    public string targetScene = "";

    // CONDITION 1
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //CONDITION 2
        if (collision.CompareTag("Player"))
        {
            ChangeScene();
        }

    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(targetScene);
    }
}
