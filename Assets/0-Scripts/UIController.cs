using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIController : MonoBehaviour
{
    public Button replayBtn ,quitBtn;
    public Transform gameOverPanel;
   
    void Start()
    {
        replayBtn.onClick.AddListener(Replay);
        quitBtn.onClick.AddListener(QuitApp);

    }
    private void Replay()
    {
       // Time.timeScale = 1;    
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene);
    }
 
    public void GameOver()
    {           
        gameOverPanel.gameObject.SetActive(true);
        //Time.timeScale = 0;
    }
    private void QuitApp()
    {       
        Application.Quit();
    }
}
