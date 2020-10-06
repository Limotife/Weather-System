/*
 * author : Kirakosyan Nikita
 * e-mail : noomank.games@gmail.com
 */
using UnityEngine;

namespace BlackMountain.Environment
{
    public class SunController : Singleton<MonoBehaviour>
    {
        [Header("Light Settings")]
        public Light sun = null;
        private Transform _sunTransform = null;

        [Header("Sky Settings")]
        public Material skyboxMaterial = null;

        private void Awake()
        {
            Initialize();
        }

        private void Update()
        {
            RotateSun();
        }

        public void Initialize()
        {
            #region Local Settings
            _sunTransform = sun.transform;
            #endregion
        }

        private void RotateSun()
        {
            float deltaRotate = Time.deltaTime / TimeOfDay.LengthOfDayInHours;
            _sunTransform.Rotate(deltaRotate, 0.0f, 0.0f);
        }
    }
}