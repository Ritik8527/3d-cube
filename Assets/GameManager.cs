using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameOver = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;


    public void LevelComplete()
    {
        completeLevelUI.SetActive(true);

    }

   public void EndGame()
   {
        if(gameOver==false)
        {
            gameOver=true;
            // Debug.Log("GameOver");
            Invoke("Restart",restartDelay);
        }
   }

   void Restart()
   {
     SceneManager.LoadScene(SceneManager.GetActiveScene().name);


   }
}
