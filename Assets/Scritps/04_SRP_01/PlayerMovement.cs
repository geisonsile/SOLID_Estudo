using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SRP_01
{
    public class PlayerMovement : MonoBehaviour
    {
        public float movementSpeed;
        private Rigidbody2D rb2d;

        private void Awake()
        {
            rb2d = GetComponent<Rigidbody2D>();
        }

        public void MovePlayer(Vector2 movementVector)
        {
            rb2d.velocity = movementVector * movementSpeed;
        }
    }
}
