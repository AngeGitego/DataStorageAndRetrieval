using UnityEngine;
using TMPro;

public class PlayerPrefsManager : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text levelText;
    public TMP_Text healthText;

    void Start()
    {
        // Save initial values
        PlayerPrefs.SetString("PlayerName", "Kevine");
        PlayerPrefs.SetInt("Level", 3);
        PlayerPrefs.SetFloat("Health", 85.5f);

        // Load and display data
        nameText.text = "Name: " + PlayerPrefs.GetString("PlayerName");
        levelText.text = "Level: " + PlayerPrefs.GetInt("Level").ToString();
        healthText.text = "Health: " + PlayerPrefs.GetFloat("Health").ToString("F1");
    }

    void Update()
    {
        // Simulate updating health over time
        float newHealth = PlayerPrefs.GetFloat("Health") - Time.deltaTime;
        PlayerPrefs.SetFloat("Health", newHealth);
        healthText.text = "Health: " + newHealth.ToString("F1");
    }
}
