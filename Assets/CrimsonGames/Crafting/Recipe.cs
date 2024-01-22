using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CrimsonGames/Recipe")]
public class Recipe: ScriptableObject
{
    public List<Item> inputItems = new List<Item>();
    public List<Item> outputItems = new List<Item>();
    public bool isExact;
}
