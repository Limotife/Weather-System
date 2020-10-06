/*
 * author : Kirakosyan Nikita
 * e-mail : noomank.games@gmail.com
 */
using UnityEngine;

namespace BlackMountain.Environment
{
    public class TimeOfDay : Singleton<MonoBehaviour>
    {
        [Header("Time Settings")]
        public float lengthOfDayInMinutes = 1.0f;
        public static float LengthOfDayInHours { get; private set; }
        public static float Seconds { get; private set; }
        public static int Minutes { get; private set; }
        public static int Hours { get; private set; }
        public static int Days { get; private set; }
        public static float TotalSecondsPassed { get; private set; }

        private void Awake()
        {
            Initialize();
        }

        private void Update()
        {
            IncreaseTime();
        }

        public void Initialize()
        {
            #region Global Settings
            LengthOfDayInHours = lengthOfDayInMinutes / 1440.0f;//1440 - minutes in 24 hours.
            Seconds = 0.0f;
            Minutes = 0;
            Hours = 0;
            Days = 0;
            TotalSecondsPassed = 0;
            #endregion
        }

        private void IncreaseTime()
        {
            float deltaTime = Time.deltaTime / LengthOfDayInHours;

            TotalSecondsPassed += Time.deltaTime;
            Seconds += deltaTime;
            if (Seconds >= 60.0f)
            {
                Seconds = 0.0f;
                Minutes++;
                if (Minutes >= 60.0f)
                {
                    Minutes = 0;
                    Hours++;
                    if (Hours >= 24)
                    {
                        Hours = 0;
                        Days++;
                    }
                }
            }
        }
    }
}