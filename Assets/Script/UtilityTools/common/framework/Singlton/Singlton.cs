using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Corprus.FrameWork
{
    public class Singlton<T> where T : new()
    {
        private static T _instance;
        public static T Instance()
        {
            if (_instance == null)
            {
                _instance = new T();
            }
            return _instance;
        }

    }
}

