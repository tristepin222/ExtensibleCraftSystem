using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using NaughtyAttributes;

[CreateAssetMenu(menuName = "CrimsonGames/Item")]
public class Item : ScriptableObject
{
    public int id;
    public string ItemName;

    [Dropdown("GetItemTypes")]
    public string itemType;

    [Dropdown("GetItemMaterials")]
    public string itemMaterial;

    [Dropdown("GetItemStates")]
    public string ItemState;

    public List<string> GetItemTypes() 
    { 
        List<string> types = new List<string>();
        ResourcesLoader.LoadAllScriptableObject("ScriptableObjects/Items/ItemType").ToList().ForEach(delegate (ItemType itemType) { types.AddRange(itemType.ItemTypes); });
        return types;
    }
    private List<string> GetItemMaterials()
    {
        List<string> types = new List<string>();
        ResourcesLoader.LoadAllScriptableObject("ScriptableObjects/Items/ItemMaterial").ToList().ForEach(delegate (ItemType itemType) { types.AddRange(itemType.ItemTypes); });
        return types;
    }
    private List<string> GetItemStates()
    {
        List<string> types = new List<string>();
        ResourcesLoader.LoadAllScriptableObject("ScriptableObjects/Items/ItemState").ToList().ForEach(delegate (ItemType itemType) { types.AddRange(itemType.ItemTypes); });
        return types;
    }

}