using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonControls : MonoBehaviour
{
    private UIManager uiManager;

    private void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    public void ResetTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void QuitTheGame()
    {
        Application.Quit();
    }
}