using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovable
{
    public Transform Transform { get; }
    public float Speed { get; }

}
