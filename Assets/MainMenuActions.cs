using UnityEngine;

public class MainMenuActions : MonoBehaviour
{
    public void RedirectToURL(string url) {
        Application.OpenURL(url);
    }
}
