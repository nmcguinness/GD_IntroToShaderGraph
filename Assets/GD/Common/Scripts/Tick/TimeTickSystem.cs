using GD.Singleton;
using System;
using UnityEngine;
using UnityEngine.Events;

namespace GD.Ticks
{
    public class TimeTickSystem : Singleton<TimeTickSystem>
    {
        #region Fields

        private readonly float maxTickInterval = 0.1f;

        public enum TickRateMultiplierType : sbyte
        {
            One = 1, Two = 2, Four = 4, Eight = 8
        }

        public uint Tick
        {
            get
            {
                return tick;
            }
        }

        private uint tick = 0;
        private float tickTimer;

        private UnityEvent OnTick_Resolution_1 = new UnityEvent();

        private UnityEvent OnTick_Resolution_2 = new UnityEvent();

        private UnityEvent OnTick_Resolution_4 = new UnityEvent();

        private UnityEvent OnTick_Resolution_8 = new UnityEvent();

        #endregion Fields

        private void Awake()
        {
            if (maxTickInterval <= 0)
                throw new Exception("Tick System Max Tick Interval must be > 0!");
        }

        private void Update()
        {
            tickTimer += Time.deltaTime;
            if (tickTimer >= maxTickInterval)
            {
                tickTimer -= maxTickInterval;

                tick++;

                OnTick_Resolution_1?.Invoke();

                if (tick % (int)TickRateMultiplierType.Two == 0)
                {
                    OnTick_Resolution_2?.Invoke();

                    if (tick % (int)TickRateMultiplierType.Four == 0)
                    {
                        OnTick_Resolution_4?.Invoke();

                        if (tick % (int)TickRateMultiplierType.Eight == 0)
                        {
                            OnTick_Resolution_8?.Invoke();
                        }
                    }
                }
            }
        }

        public void RegisterListener(TickRateMultiplierType tickRateType, UnityAction listener)
        {
            switch (tickRateType)
            {
                case TickRateMultiplierType.One:
                    OnTick_Resolution_1.AddListener(listener);
                    break;

                case TickRateMultiplierType.Two:
                    OnTick_Resolution_2.AddListener(listener);
                    break;

                case TickRateMultiplierType.Four:
                    OnTick_Resolution_4.AddListener(listener);
                    break;

                case TickRateMultiplierType.Eight:
                    OnTick_Resolution_8.AddListener(listener);
                    break;
            }
        }

        public void UnregisterListener(TickRateMultiplierType tickRateType, UnityAction listener)
        {
            switch (tickRateType)
            {
                case TickRateMultiplierType.One:
                    OnTick_Resolution_1.RemoveListener(listener);
                    break;

                case TickRateMultiplierType.Two:
                    OnTick_Resolution_2.RemoveListener(listener);
                    break;

                case TickRateMultiplierType.Four:
                    OnTick_Resolution_4.RemoveListener(listener);
                    break;

                case TickRateMultiplierType.Eight:
                    OnTick_Resolution_8.RemoveListener(listener);
                    break;
            }
        }
    }
}