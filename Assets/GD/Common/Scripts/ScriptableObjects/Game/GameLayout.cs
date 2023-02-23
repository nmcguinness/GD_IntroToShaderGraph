using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Stores data relating to a complete game (i.e. multiple levels)
/// </summary>
/// <see cref="https://blogs.unity3d.com/2020/07/01/achieve-better-scene-workflow-with-scriptableobjects/"/>
namespace GD.GameLayout
{
    [CreateAssetMenu(fileName = "GameLayout", menuName = "Scriptable Objects/Game/Layout")]
    public class GameLayout : ScriptableObject
    {
        [System.Serializable]
        public enum LifecycleStage
        {
            PreAlpha, Alpha, Beta, ReleaseCandidate, StableRelease, EndOfLife
        }

        [Header("Level Layout")]
        [SerializeField]
        private List<GameLevel> levels;

        [SerializeField]
        [Min(0)]
        [Tooltip("Zero-based index in the list of level layouts for the start level in the game (e.g. 0)")]
        private int startLevel;

        [Header("Menu Layout")]
        [SerializeField]
        private GameScene mainMenu;

        [SerializeField]
        private GameScene pauseMenu;

        [SerializeField]
        private GameScene uiMenu;

        [Space(10)]
        [Header("Version & Documentation Details (optional)")]
        [SerializeField]
        private LifecycleStage lifecycleStage;

        [SerializeField]
        [Min(1)]
        private float version;

        [SerializeField]
        private string lastModifiedDate;  //we could consider a custom property here for datetime

        [Header("Level Design Team")]
        [SerializeField]
        private string teamLead;

        [Header("Supporting Documentation")]
        [SerializeField]
        private string documentationURL;

        [HideInInspector]
        public int currentLevel;

        //TODO
        public void NextLevel()
        {
            //load next level
        }

        //Restart current level
        public void RestartLevel()
        {
            //reset
        }

        //New game, load level 1
        public void NewGame()
        {
            //set current back to start level
        }

        public void LoadMainMenu()
        {
            // SceneManager.LoadSceneAsync(/*main name*/);
        }

        public void LoadPauseMenu()
        {
            // SceneManager.LoadSceneAsync(/*pause name*/);
        }

        public void SaveGame()
        {
            // AssetDatabase
        }

        public void LoadGame()
        {
            // AssetDatabase
        }
    }
}