using UnityEngine;


public class WinCondition : MonoBehaviour
{
    private UIManager uiManager;
    public GameObject Canvas;

    private void Start()
    {
        uiManager = Canvas.GetComponent<UIManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            uiManager.Win();

        }
    }
}
