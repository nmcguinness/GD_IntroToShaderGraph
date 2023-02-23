using GD.Enums;
using UnityEngine;

/// <summary>
/// Stores data relating to a level objective
/// </summary>
/// <see cref="GD.ScriptableTypes.RuntimeGameObjectiveList"/>
namespace GD.GameLayout
{
    [CreateAssetMenu(fileName = "GameObjective", menuName = "Scriptable Objects/Game/Objective")]
    public class GameObjective : ScriptableObject
    {
        //[ColorPalette]  //Odin Inspector Demo
        //public Color color;

        [Header("Completion Status")]
        [Tooltip("Set by the script attached to the object or by the game manager. By default all objectives are not completed at level startup")]
        public bool IsCompleted;

        [Header("UI Icon & Description")]
        [Tooltip("May be used by a dialog box or UI element to add an icon to the objective description")]
        public Sprite Icon;

        [Tooltip("Shown on-screen as dialog text or in a UI. Note: Length will affect UI layout and font size")]
        public string Description;

        [Header("Priority (optional)")]
        [Tooltip("Priority used to mark how important objectives are when completing the level (default is Normal)")]
        public PriorityType Priority;

        [Header("Waypoint Settings (optional)")]
        [Tooltip("Specify action keyword shown with objective waypoint marker (e.g. Activate, Protect, Unlock)")]
        public string Keyword;

        [Tooltip("Transform specifying the position for the waypoint")]
        public Vector3 Position;

        [Tooltip("Specify when an onscreen waypoint is shown")]
        public VisibilityStrategyType Visibility;

        [Range(1, 1000)]
        [Tooltip("If visibility is Show Within then the waypoint will only show within the distance specified")]
        public float ShownWithinDistance;

        [Header("Time Dependent (optional)")]
        [Tooltip("Flag indicating that the objective must be completed in the timeLimitSecs duration")]
        public bool IsTimeLimited;

        [Min(0)]
        [Tooltip("Amount of time before which the player will automatically fail to complete the level objectives")]
        public int timeLimitSecs;

        [Tooltip("Audio clip played when the time limit is being reached")]
        public AudioClip timeLimitAudioClip;

        [Range(1, 60)]
        [Tooltip("Time in seconds before the time limit elapses when we start to play the time limit audio clip. Must be less than Time Limit Secs value.")]
        public float playTimeLimitAudioBeforeSecs;

        [Header("Completion Feedback (optional)")]
        [Tooltip("Completion text shown when the objective has been achieved")]
        public string AchievementText;

        [Tooltip("Audio clip played when the objective has been achieved")]
        public AudioClip AchievementAudioClip;
    }
}