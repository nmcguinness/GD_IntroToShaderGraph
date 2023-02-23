using UnityEngine;

namespace GD.Selection
{
    public class SoundSelectionResponse : MonoBehaviour, ISelectionResponse
    {

        [SerializeField]
        private AudioClip selectedAudioClip;
        private Transform currentTransform = null;

        public void OnDeselect(Transform transform)
        {
            
        }

        public void OnSelect(Transform transform)
        {
            if(currentTransform != null && currentTransform != transform)
                AudioSource.PlayClipAtPoint(selectedAudioClip, transform.position);

            currentTransform = transform;

        }
    }
}