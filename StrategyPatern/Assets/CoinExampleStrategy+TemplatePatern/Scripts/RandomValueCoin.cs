using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomValueCoin : Coin
{
    [SerializeField, Range(0, 50)] private int _maxValue;
    [SerializeField, Range(0, 50)] private int _minValue;


    private void OnValidate()
    {
        if (_maxValue <= _minValue)
            _maxValue = _minValue + 1;
    }
    
    protected override void AddCoins(ICoinPicker coinPicker) => coinPicker.Add(Random.Range(_minValue, _maxValue));
}
