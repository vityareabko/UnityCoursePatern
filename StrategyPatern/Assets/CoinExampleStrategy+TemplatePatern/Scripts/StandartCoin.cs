using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandartCoin : Coin
{
    [SerializeField, Range(0, 50)] private int _value;

    protected override void AddCoins(ICoinPicker coinPicker) => coinPicker.Add(_value);
}
