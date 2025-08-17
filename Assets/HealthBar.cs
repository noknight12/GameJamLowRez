using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    // Set the max health of the slider
    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    // Update the slider when health changes
    public void SetHealth(float health)
    {
        slider.value = health;
    }
}
