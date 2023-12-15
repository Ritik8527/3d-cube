using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter() // MAKE SURE TO TICK ON "IS TRIGGER " IN RIGID BODY.
    {
        gameManager.LevelComplete();
    }


}
