using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CrimsonGames/ItemTypeScriptableObject")]
public class ItemType : ScriptableObject
{
    public List<string> ItemTypes = new List<string>();
}
