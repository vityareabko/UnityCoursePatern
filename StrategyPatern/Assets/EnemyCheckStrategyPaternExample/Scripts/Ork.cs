using System.Collections.Generic;
using UnityEngine;

public class Ork : Character
{
    protected override void Affect(IEnumerable<Character> characters)
    {
        foreach (var character in characters)
            Debug.Log(character.name);
    }
}
