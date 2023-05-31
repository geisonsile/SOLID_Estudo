using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OCP_01
{
    public interface IMovementInput
    {
        Vector2 MovementInputVector { get; }
        event Action OnInteractEvent;
    }
}
