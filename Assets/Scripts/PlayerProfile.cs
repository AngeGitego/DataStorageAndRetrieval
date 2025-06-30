using UnityEngine;

[CreateAssetMenu(fileName = "New Player Profile", menuName = "Custom/Player Profile")]
public class PlayerProfile : ScriptableObject
{
    public string playerName;
    public int level;
    public float health;
}
