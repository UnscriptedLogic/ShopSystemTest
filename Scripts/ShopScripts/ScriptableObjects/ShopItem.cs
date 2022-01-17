using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Shop Item", menuName = "ScriptableObjects/Shop Item")]
public class ShopItem : ScriptableObject
{
    public Sprite icon;
    public float cost = 10;

    [TextArea(10, 20)]
    public string description = "This item's description is empty.";
}
