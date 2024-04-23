using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image singlehealthBar;
    [SerializeField] private Image currenthealthBar;

    private void Start () 
    {
        singlehealthBar.fillAmount = playerHealth.currentHealth;
    }

    private void Update () 
    {
        currenthealthBar.fillAmount = playerHealth.currentHealth;
    }
}
