using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour { 

    bool gameHasEnded = false;

    public GameObject completeLevelUI;

    public float restartDelay = 0.5f;

    public void CompleteLevel ()
    {
        //Debug.Log("Complete Level");
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
            //Restart();
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //current scene
    }
}
