using System.Collections.Generic;
using UnityEngine;

public class PointByPointMover : IMove
{
    private const float MinDistanceToTarger = 0.05f;
    
    private Queue<Vector3> _targetPoints;
    private Vector3 _currentTarget;
    private IMovable _movable;
    private bool isMoving;

    public PointByPointMover(IMovable movable, IEnumerable<Vector3> targetPoints)
    {
        _movable = movable;
        _targetPoints = new Queue<Vector3>(targetPoints);
        
        SwitchTarget();
    }

    public void StartMove() => isMoving = true;
    public void StopMove() => isMoving = false;
    public void Update()
    {
        throw new System.NotImplementedException();
    }

    public void Update(float deltaTime)
    {
        if (!isMoving)
            return;

        Vector3 direction = _currentTarget - _movable.Transform.position;
        _movable.Transform.Translate(direction.normalized * _movable.Speed * deltaTime);
        
        if (direction.magnitude <= MinDistanceToTarger)
            SwitchTarget();
        
    }

    private void SwitchTarget()
    {
        if (_currentTarget != null)
            _targetPoints.Enqueue(_currentTarget);

        _currentTarget = _targetPoints.Dequeue();
    }

}
