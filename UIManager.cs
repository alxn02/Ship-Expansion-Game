using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Ship ship;
    public Text fuelText;
    public Text scoreText;

    void Update()
    {
        if (ship != null)
        {
            fuelText.text = "Fuel: " + ship.fuel;
            scoreText.text = "Score: " + ship.score;
        }
    }
}
