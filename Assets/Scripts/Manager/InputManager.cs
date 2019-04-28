using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectBase
{
    public class InputManager : MonoBehaviour
    {
        public static InputManager instance;

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
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                GameManager.instance.QuitGame();
            }
        }
    }
}

