using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public void LoadzScene(string StartScene)
    {
        SceneManager.LoadScene(StartScene);
    }
}