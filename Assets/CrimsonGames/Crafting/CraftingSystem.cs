using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class CraftingSystem
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

       
        return null;
    }
}

class EmptyRecipeException : Exception { }
class EmptyInputException : Exception { }