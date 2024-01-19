using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ResourcesLoader
{
    public static ScriptableObject LoadScriptableObject(string path)
    {
        return Resources.Load(path) as ScriptableObject;
    }
    public static ItemType[] LoadAllScriptableObject(string path)
    {
        return Resources.LoadAll<ItemType>(path);
    }
}
