using UnityEngine;
using UnityEngine.SceneManagement;

public class newLevel : MonoBehaviour
{
    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
