using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SRP_03
{
    public class GameManager : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            SceneManager.LoadScene("PremadeLevel", LoadSceneMode.Additive);
        }
    }
}
