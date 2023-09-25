using System.Collections.Generic;
using UnityEngine;

public class ViewAroundPatern : ICharacterFinder
{
    private Transform _transform;
    private float _radiusView;

    public ViewAroundPatern(Transform transform, float radiusView)
    {
        _transform = transform;
        _radiusView = radiusView;
    }
    
    public IEnumerable<Character> Find()
    {

        var colliders = Physics.OverlapSphere(_transform.position, _radiusView);
        List<Character> findedCharacters = new List<Character>();
        
        foreach (var collider in colliders)
            if (collider.TryGetComponent(out Character character))
                if (character.transform != _transform)
                    findedCharacters.Add(character);

        return findedCharacters;
    }
}
