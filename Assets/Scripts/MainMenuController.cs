
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("FirstLevelScene");
    }

    public void options()
    {

    }

    public void exitGame()
    {
        Application.Quit();
    }
}
