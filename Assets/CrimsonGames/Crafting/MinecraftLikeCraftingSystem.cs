using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinecraftLikeCraftingSystem : CraftingSystem
{
    public new List<Item> Craft(Recipe recipe, List<Item> inputs)
    {
        base.Craft(recipe, inputs);

        int index = 0;
        bool isCraftable = true;
        if (recipe.isExact)
        {
            foreach (Item item in inputs)
            {
                if (item.itemType == recipe.inputItems[index].itemType)
                {
                    isCraftable = true;
                }
                else
                {
                    isCraftable = false;
                }
            }
            if (isCraftable)
            {
                return recipe.outputItems;
            }
        }
        else
        {
            foreach (Item item in inputs)
            {
                if (item.itemType == recipe.inputItems[index].itemType)
                {
                    isCraftable = true;
                }
                if (item.itemType != recipe.inputItems[index].GetItemTypes()[0])
                {
                    isCraftable = false;
                }
            }
            if (isCraftable)
            {
                return recipe.outputItems;
            }
        }
        return null;
    }
}
