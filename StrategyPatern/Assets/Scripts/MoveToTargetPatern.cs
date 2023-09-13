
using UnityEngine;

public class MoveToTargetPatern : IMove
{
    private Transform _target;
    private IMovable _movable;

    private bool _isMoving;

    public MoveToTargetPatern(IMovable movable, Transform target)
    {
        _target = target;
        _movable = movable;
    }
    
    public void StartMove() => _isMoving = true;
    
    public void StopMove() => _isMoving = false;
    

    public void Update(float deltaTime)
    {
        if (!_isMoving)
            return;

        Vector3 direction = _target.position - _movable.Transform.position;
        _movable.Transform.Translate(direction.normalized * _movable.Speed * deltaTime);
    }
}
