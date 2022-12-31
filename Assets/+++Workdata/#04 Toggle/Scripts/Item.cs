using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Items/Item", order = 1)]
public class Item : ScriptableObject
{
    public Sprite itemSprite;
    public int itemId;
    public string itemName;
    public int itemValue;
    public string itemDescription;
}