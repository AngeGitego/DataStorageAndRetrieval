using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Kevine/PlayerData", order = 100)]
public class PlayerData : ScriptableObject
{
    public string playerName;
    public int score;
    public float health;
    public Texture playerIcon;
}
