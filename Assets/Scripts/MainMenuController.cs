using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject settingsPanel;
    public Animator settingsAnimator;

    public void OpenSettings()
    {
        if (settingsPanel != null && settingsAnimator != null)
        {
            settingsPanel.SetActive(true);
            settingsAnimator.SetTrigger("Open");
        }
    }
    public void CloseSettings()
    {
        if (settingsPanel != null && settingsAnimator != null)
        {
            settingsAnimator.SetTrigger("Close");
        }
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
