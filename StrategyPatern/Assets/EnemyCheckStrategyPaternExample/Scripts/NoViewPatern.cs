using System.Collections.Generic;


public class NoViewPatern : ICharacterFinder
{
    public IEnumerable<Character> Find() { return null; }
}
