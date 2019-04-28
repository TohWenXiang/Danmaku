using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectBase
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        void Awake()
        {
            //---------------------singleton code---------------------
            if (instance == null)
            {
                DontDestroyOnLoad(gameObject);
                instance = this;
            }
            else if (instance != this)
            {
                Destroy(gameObject);
            }
            //--------------------------------------------------------
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}
