using UnityEngine;
using UnityEngine.SceneManagement;

public class P1Score : MonoBehaviour
{
    // Reset the score at the start of the game
    void Start()
    {
        // if it's the zeroth scene (buildIndex == 0)
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 0)
        {
            // reset the score
            PlayerPrefs.SetInt("P1Score", 0);
        }
        GetComponent<UnityEngine.UI.Text>().text = PlayerPrefs.GetInt("P1Score").ToString();
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("P1Score") >= 100)
        SceneManager.LoadScene("P1Win");
    }
}
