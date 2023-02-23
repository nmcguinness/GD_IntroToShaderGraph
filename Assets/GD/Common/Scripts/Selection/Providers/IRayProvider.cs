using UnityEngine;

namespace GD.Selection
{
    public interface IRayProvider
    {
        Ray CreateRay();
    }
}
