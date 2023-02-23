using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

/// <summary>
/// Stores data relating to a single scene within a level
/// </summary>
/// <see cref="https://blogs.unity3d.com/2020/07/01/achieve-better-scene-workflow-with-scriptableobjects/"/>
namespace GD.GameLayout
{
    [CreateAssetMenu(fileName = "GameScene", menuName = "Scriptable Objects/Game/Scene")]
    public class GameScene : ScriptableObject
    {
        [Header("Scene Description")]
        [SerializeField]
        [Tooltip("Ensure that the object provided is a valid Unity scene")]
        private Object sceneObject; //store as generic object so that if we change scene name we can access the new name

        [SerializeField]
        private string description;

        [Header("Music")]
        [SerializeField]
        private AudioClip backgroundMusic;

        [SerializeField]
        [Range(0, 1)]
        [Tooltip("Overrides the volume set in any audio mixer with this value")]
        private float overrideVolume;  //Would a FloatReference be useful here? Why?

        [Header("Visuals")]
        [Header("Post-processing")]
        [SerializeField] private VolumeProfile defaultPostProcessProfile;

        public string Name
        {
            get
            {
                if (!sceneObject.GetType().Equals(typeof(Scene)))
                    throw new System.Exception($"{sceneObject.name} is not a valid scene!");

                return sceneObject.name;
            }
        }
    }
}