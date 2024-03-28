using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameScript : MonoBehaviour
{

    [SerializeField] private string EndGameStart = "EndMenuScene";

    private void OnTriggerEnter2D(Collider2D collider)
    {
        SceneManager.LoadScene(EndGameStart);
    }

}
