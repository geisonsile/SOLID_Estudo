using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SRP_02
{
    public class PlayeSounds : MonoBehaviour
    {
        public AudioSource audioSource;
        public void PlayStepSound()
        {
            audioSource.Play();
        }
    }
}
