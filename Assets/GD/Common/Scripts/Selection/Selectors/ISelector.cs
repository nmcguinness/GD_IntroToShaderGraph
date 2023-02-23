using UnityEngine;

namespace GD.Selection
{
    public interface ISelector
    {
        void Check(Ray ray);

        Transform GetSelection();

        RaycastHit GetHitInfo();
    }
}