using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickRotate : MonoBehaviour
{

    public static bool startClick = false; // first click current game
    public static bool FlipXZ; // if TRUE-right, else FALSE - forward

    public GameObject StartText;
    
    private void OnMouseUpAsButton()
    {
        if (ReloadScens.lose == true) // reload if lose
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (startClick == false)
        {
            startClick = true; // start game (scrpt "PlayerMove")

            StartText.SetActive(false);
        } else
        {
            FlipXZ = !FlipXZ; // rotate (scrpt "PlayerMove")
        }

    }
}
