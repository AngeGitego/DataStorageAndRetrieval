using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayItem : MonoBehaviour
{
    public ItemData itemData;
    public TMP_Text titleText;
    public Image iconImage;

    void Start()
    {
        titleText.text = itemData.title;
        iconImage.sprite = itemData.icon;
    }
}
