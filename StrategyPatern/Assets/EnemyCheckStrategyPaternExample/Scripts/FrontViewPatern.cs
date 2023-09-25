using System.Collections.Generic;
using UnityEngine;

public class FrontViewPatern : ICharacterFinder
{
    private Transform _transform;
    private float _rangeView;

    public FrontViewPatern(Transform transform, float rangeView)
    {
        _transform = transform;
        _rangeView = rangeView;
    }


    public IEnumerable<Character> Find()
    {
        RaycastHit[] hitDetected = Physics.RaycastAll(new Ray(_transform.position, _transform.forward), _rangeView);

        List<Character> _findedCharacters = new List<Character>();

        foreach (var raycastHit in hitDetected)
            if (raycastHit.collider.TryGetComponent(out Character character))
                if (character.transform != _transform)
                    _findedCharacters.Add(character);

        return _findedCharacters;
    }
}