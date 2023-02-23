using System.Collections;
using UnityEngine;

namespace GD.Managers
{
    /// <summary>
    /// Inherit from this class to define what happens when the level starts, ends, and what toasts are shown at beginning and end
    /// </summary>
    /// <see cref="MyGame.MyGameManager"/>
    public abstract class GameManager : MonoBehaviour
    {
        #region Fields

        [SerializeField]
        [Range(0, 10)]
        [Tooltip("Time in seconds to wait to show start toasts. Once the game starts this value cannot be changed in real-time.")]
        private float startLevelWaitSeconds = 1;

        [SerializeField]
        [Range(0, 10)]
        [Tooltip("Time in seconds to before repeating the game loop which tests win/lose conditions. Once the game starts this value cannot be changed in real-time.")]
        private float playLoopWaitSeconds = 0.5f;

        [SerializeField]
        [Range(0, 10)]
        [Tooltip("Time in seconds to wait to show end toasts. Once the game starts this value cannot be changed in real-time.")]
        private float endLevelWaitSeconds = 5;

        protected WaitForSeconds startWait;
        protected WaitForSeconds endWait;
        protected WaitForSeconds playLevelWait;
        private bool isPaused;

        #endregion Fields

        #region Properties

        public bool IsPaused
        {
            get
            {
                return isPaused;
            }
            set
            {
                if (value != isPaused)
                {
                    isPaused = value;

                    //un-/pauses time within the game FOR ALL scaled time objects
                    Time.timeScale = isPaused ? 0 : 1;
                }
            }
        }

        #endregion Properties

        /// <summary>
        /// Stop all outstanding coroutines (e.g. any waits)
        /// </summary>
        private void OnDestroy()
        {
            StopAllCoroutines();
        }

        /// <summary>
        /// Get a reference to all wait timers used within the game and cache - cheaper than instanciating new WaitForSeconds() during gameplay
        /// </summary>
        protected virtual void InitializeWaits()
        {
            startWait = new WaitForSeconds(startLevelWaitSeconds);
            endWait = new WaitForSeconds(endLevelWaitSeconds);
            playLevelWait = new WaitForSeconds(playLoopWaitSeconds);
        }

        /// <summary>
        /// Core loop for the manager that loops until win/lose conditions are fulfilled or pause event occurs
        /// </summary>
        /// <returns></returns>
        protected virtual IEnumerator GameLoop()
        {
            yield return StartCoroutine(StartLevel());
            yield return StartCoroutine(PlayLevel());
            yield return StartCoroutine(EndLevel());
        }

        /// <summary>
        /// Test win/lose logic and check for pause
        /// </summary>
        /// <returns></returns>
        protected virtual IEnumerator PlayLevel()
        {
            //loop until some end condition is reached e.g. all objectives have been completed, all inventory items collected etc
            for (; ; ) //we will replace this infinite loop with some termination boolean expression e.g. while(isCompleted == false)
            {
                //add the game logic here that tests for end conditions
                CheckWinLose();

                //yield if the game is paused i.e. showing a menu
                yield return new WaitWhile(() => isPaused);

                //yield control for a period of time
                yield return playLevelWait;
            }
        }

        /// <summary>
        /// Call to play the game
        /// </summary>
        public virtual void Play()
        {
            IsPaused = true;
        }

        /// <summary>
        /// Call to pause the game
        /// </summary>
        public virtual void Pause()
        {
            IsPaused = false;
        }

        /// <summary>
        /// Call to pause the game
        /// </summary>
        public virtual void TogglePause()
        {
            IsPaused = !isPaused;
        }

        /// <summary>
        /// Perform operations to start level (e.g. load content)
        /// </summary>
        /// <returns></returns>
        protected abstract IEnumerator StartLevel();

        /// <summary>
        /// Override and show start toast/info
        /// </summary>
        protected abstract void ShowStartToast();

        /// <summary>
        /// Override and check what conditions constitute win/lose
        /// </summary>
        protected abstract void CheckWinLose();

        /// <summary>
        /// Override and show end toast/info
        /// </summary>
        protected abstract void ShowWinLoseToast();

        /// <summary>
        /// Perform operations to end level (e.g. serialize game state, take screenshot of level)
        /// </summary>
        /// <returns></returns>
        protected abstract IEnumerator EndLevel();
    }
}