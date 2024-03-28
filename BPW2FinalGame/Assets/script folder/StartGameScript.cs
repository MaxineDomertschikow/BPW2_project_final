using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour
{

    [SerializeField] private string newGameStart = "GameScene";

    public void NextScene()
    {
        SceneManager.LoadScene(newGameStart);
    }

}
