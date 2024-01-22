using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class CraftingSystem : MonoBehaviour
{
    public List<Item> Craft(Recipe recipe, List<Item> inputs)
    {
        if (recipe == null)
        {
            throw new EmptyRecipeException();
        }

        if(inputs == null || inputs.Count == 0)
        {
            throw new EmptyInputException();
        }

        int index = 0;
        bool isCraftable = true;
        if (recipe.isExact)
        {
            foreach (Item item in inputs) 
            { 
                if(item.itemType == recipe.inputItems[index].itemType)
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
                if(item.itemType != recipe.inputItems[index].GetItemTypes()[0])
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

class EmptyRecipeException : Exception { }
class EmptyInputException : Exception { }