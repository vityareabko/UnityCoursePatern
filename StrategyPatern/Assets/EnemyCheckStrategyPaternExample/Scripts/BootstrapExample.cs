using System.Collections.Generic;
using UnityEngine;

public class BootstrapExample : MonoBehaviour
{
    [SerializeField] private Ork _ork;
    [SerializeField] private List<Human> _humans;

    private void Awake()
    {
        InitializeOrk();
        InitializeHuman();
    }

    private void InitializeHuman()
    {
        foreach (var human in _humans)
        {
            human.Initialize(new NoViewPatern(), character => character is Ork);
        }
    }

    private void InitializeOrk()
    {
        _ork.Initialize(new ViewAroundPatern(_ork.transform, 5f), character => character is Human);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(_ork.transform.position, 5f); 
    }
}
