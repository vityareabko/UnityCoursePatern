using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.TryGetComponent(out ICoinPicker coinPicker))
        {
            Debug.Log("Музыка подбора монетки");
            Debug.Log("анимация подбора монетки");
            
            // начисления монетки
            AddCoins(coinPicker);
            
            Destroy(gameObject);
        }
    }

    protected abstract void AddCoins(ICoinPicker coinPicker);

}
