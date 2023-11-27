using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuActions : MonoBehaviour
{
    public void GoToScene (string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitApp() {
        Application.Quit();
        Debug.Log("Quitting game");
    }

    public void RedirectToURL(string url) {
        Application.OpenURL(url);
    }
}
