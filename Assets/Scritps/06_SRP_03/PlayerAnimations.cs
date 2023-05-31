using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SRP_03
{
    public class PlayerAnimations : MonoBehaviour
    {
        public Animator playerAnimator;

        public void SetupAnimations(Vector2 movementVEctor)
        {
            if (movementVEctor.magnitude > 0)
            {
                playerAnimator.SetBool("Walk", true);
            }
            else
            {
                playerAnimator.SetBool("Walk", false);
            }
        }
    }
}
