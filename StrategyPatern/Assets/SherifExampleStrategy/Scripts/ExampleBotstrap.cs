
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ExampleBotstrap : MonoBehaviour
{
    [SerializeField] private Sherif _sherif;
    [SerializeField] private Transform _target;
    [SerializeField] private List<Transform> _patrolPoints;

    private void Awake()
    {
        _sherif.Initialize(new NoMovePatern());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            _sherif.SetMover(new NoMovePatern());
        
        if (Input.GetKeyDown(KeyCode.W))
            _sherif.SetMover(new PointByPointMover(_sherif, _patrolPoints.Select(point => point.position)));
        
        if (Input.GetKeyDown(KeyCode.E))
            _sherif.SetMover(new MoveToTargetPatern(_sherif, _target));
        
    }
}
