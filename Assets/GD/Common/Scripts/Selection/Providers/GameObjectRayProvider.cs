using UnityEngine;

namespace GD.Selection
{
    public class GameObjectRayProvider : IRayProvider
    {
        [SerializeField]
        private GameObject rayOrigin;

        public Ray CreateRay()
        {
            return new Ray(rayOrigin.transform.position, rayOrigin.transform.forward);
        }
    }
}