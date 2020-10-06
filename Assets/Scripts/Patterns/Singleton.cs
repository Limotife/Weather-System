/*
 * author : Kirakosyan Nikita
 * e-mail : noomank.games@gmail.com
 */
using UnityEngine;

namespace BlackMountain.Environment
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance = null;

        public static T instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<T>();
                    if (_instance == null)
                    {
                        Debug.LogError("Can't find " + typeof(T) + "!");
                    }
                }

                return _instance;
            }
        }
    }
}