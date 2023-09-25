using System;
using UnityEngine;

public class Sherif : MonoBehaviour, IMovable
{
    private IMove _mover;
    private bool _isInit;

    public void Initialize(IMove moveState)
    {
        SetMover(moveState);
        _mover = moveState;
        _isInit = true;
    }

    [HideInInspector] public Transform Transform => transform;
    [field: SerializeField] public float Speed { get; private set; }
    
    private void Update()
    {
        if (!_isInit)
            throw new InvalidOperationException(nameof(_isInit));
        
        _mover.Update(Time.deltaTime);
    }

    public void SetMover(IMove moveState)
    {
        _mover?.StopMove();
        _mover = moveState;
        _mover.StartMove();
    }

}
