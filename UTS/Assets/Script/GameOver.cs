using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {

    }
    public void Restart()
    {
        
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
