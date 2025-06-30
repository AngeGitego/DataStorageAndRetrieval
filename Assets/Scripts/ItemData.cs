using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Custom/Item")]
public class ItemData : ScriptableObject
{
    public string title;
    public Sprite icon;
}
