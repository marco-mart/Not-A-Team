using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health johnHealth;
    [SerializeField] private Image totalHealthBar;
    [SerializeField] private Image currentHealthBar;

    // Start is called before the first frame update
    void Start()
    {
        // must divide by 10 cause the health bar sprite 
        // image has 10 hearts, while we only want to work with 3
        totalHealthBar.fillAmount = johnHealth.getCurrentHealth() / 10;
    }

    // Update is called once per frame
    void Update()
    {
        // must divide by 10 cause the health bar sprite 
        // image has 10 hearts, while we only want to work with 3
        currentHealthBar.fillAmount = johnHealth.getCurrentHealth() / 10;
    }
}
