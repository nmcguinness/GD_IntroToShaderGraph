using GD.Ticks;
using UnityEngine;
using static GD.Ticks.TimeTickSystem;

namespace GD.Lighting
{
    public class DynamicReflectionProbeRefresher : MonoBehaviour, IHandleTicks
    {
        [SerializeField]
        [Tooltip("Select how often the reflection probe will be updated (e.g. once every 1, 2, 4, 8, or 16 frames)")]
        private TickRateMultiplierType tickRate = TickRateMultiplierType.Two;

        private ReflectionProbe reflectionProbe;

        // Here we update only when the TimeTickSystem calls this callback method
        public void HandleTick()
        {
            reflectionProbe.RenderProbe();
        }

        private void Awake()
        {
            //register with the TimeTickSystem - remove this and HandleTick will never be called!
            TimeTickSystem.Instance.RegisterListener(tickRate, HandleTick);

            //cache(i.e store once rather than repeatedly call GetComponent()) a reference to the probe
            reflectionProbe = GetComponent<ReflectionProbe>();

            //call HandleTick on awake so that we don't have to wait too long (e.g. 1/16th) for the first update to the probe
            HandleTick();
        }

        // Update is called once per frame
        // Instead of writing code to update the reflection probe based on frame count, why not use the TimeTickSystem?
        //private void Update()
        //{
        //    //every 15 updates (at 60fps) that is 240ms
        //    reflectionProbe.RenderProbe();
        //}
    }
}