using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;  // as we can see Text is responsible for text shown in area hence we choosed type text.

    // Update is called once per frame
    void Update()
    {
        
        scoreText.text=player.position.z.ToString();
    }
}
