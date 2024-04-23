using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject GameOverScreen;
    public GameObject WinScreen;

    private void Start()
    {
        Time.timeScale = 1;
        GameOverScreen.SetActive(false);
        WinScreen.SetActive(false);
    }

    public void GameOver()
    {
        GameOverScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Win()
    {
        WinScreen.SetActive(true);
        Time.timeScale = 0f;
    }
}