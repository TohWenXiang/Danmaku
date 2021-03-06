﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectBase
{
    public class Manager : MonoBehaviour
    {
        public static Manager instance;

        protected virtual void Awake()
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
        protected virtual void Start()
        {

        }

        // Update is called once per frame
        protected virtual void Update()
        {

        }
    }
}

