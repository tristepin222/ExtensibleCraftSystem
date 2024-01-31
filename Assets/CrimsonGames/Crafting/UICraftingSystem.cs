using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICraftingSystem : MonoBehaviour
{
    public enum CraftingMode
    {
        MinecraftLike,
        FactorioLike
    }
    public CraftingMode mode;
    private CraftingSystem craftingSystem;
    // Start is called before the first frame update
    void Start()
    {
        switch (mode)
        {
            case CraftingMode.MinecraftLike:
                craftingSystem = new MinecraftLikeCraftingSystem();
            break;
            case CraftingMode.FactorioLike:
            break;
        }
        
    }

}
