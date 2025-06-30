using UnityEngine;
using TMPro;

public class DisplayPlayerProfile : MonoBehaviour
{
    public PlayerProfile playerData;
    public TMP_Text nameText;
    public TMP_Text levelText;
    public TMP_Text healthText;

    void Start()
    {
        nameText.text = "Name: " + playerData.playerName;
        levelText.text = "Level: " + playerData.level.ToString();
        healthText.text = "Health: " + playerData.health.ToString("F1");
    }
}
