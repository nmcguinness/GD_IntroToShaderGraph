using GD.Enums;
using UnityEngine;

namespace GD.Objects
{
    [CreateAssetMenu(fileName = "PlaceableObjectData", menuName = "Scriptable Objects/Game/Objects/Placeable")]
    public class PlaceableObjectData : BaseObjectData
    {
        //add game event here - OnDestroy, OnSpawn

        [Header("Units & Buildings")]
        [Tooltip("Type of objects attacked by this object")]
        public AttackTargetType TargetType;

        [Tooltip("Attack type used by this object")]
        public AttackType AttackType;

        [Tooltip("Damage inflicted by this object with each attack")]
        [Range(0, 1000)]
        public int DamagePerAttack;

        [Tooltip("Range over which this unit can attack")]
        [Range(0, 1000)]
        public int AttackRange;

        [Tooltip("Rate at which this unit can attack (-1 for random rate in range)")]
        [Range(0, 60000)]
        public int AttackRateMs;

        [Tooltip("Audio clipped played when attacking")]
        public AudioClip AttackClip;

        [Tooltip("Audio clipped played when dead")]
        public AudioClip DieClip;

        [Header("Movement")]
        [Range(0, 1000)]
        public float MoveSpeed;

        [Range(0, 1000)]
        public float StrafeSpeed;

        [Range(0, 1000)]
        public float RotateSpeed;
    }
}