using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SRP_01
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
