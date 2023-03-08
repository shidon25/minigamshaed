using UnityEngine;
using UnityEngine.SceneManagement;

public class NextGame : MonoBehaviour
{
    public void LoadScenez(string PlaceHolder)
    {
        SceneManager.LoadScene(PlaceHolder);
    }
    //when changing placeholder change scene name in the button too
}