using UnityEngine;

namespace GD.Selection
{
    public class SoundSelectionResponse : MonoBehaviour, ISelectionResponse
    {
        [SerializeField]
        private AudioClip selectedAudioClip;

        private Transform currentTransform = null;

        void ISelectionResponse.OnDeselect(Transform transform)
        {
            if (currentTransform != null && currentTransform != transform)
                AudioSource.PlayClipAtPoint(selectedAudioClip, transform.position);

            currentTransform = transform;
        }

        void ISelectionResponse.OnSelect(Transform transform, RaycastHit hitInfo)
        {
            if (currentTransform != null && currentTransform != transform)
                AudioSource.PlayClipAtPoint(selectedAudioClip, transform.position);

            currentTransform = transform;
        }
    }
}