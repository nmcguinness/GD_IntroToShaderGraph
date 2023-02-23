using UnityEngine;

namespace GD.Singleton
{
    //See the following video tutorials before using this class in your code
    //Singletons & Managers in Unity - https://www.youtube.com/watch?v=92NQVeFiDeY
    //Everything You Need to Know About Singletons in Unity - https://www.youtube.com/watch?v=mpM0C6quQjs
    //How To Access Variables From Another Script In Unity - https://www.youtube.com/watch?v=-kd68uKt4jk
    //See C# Generics - https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(T).ToString();
                    obj.hideFlags = HideFlags.HideAndDontSave; //uncomment to hide in Hierarchy window and dont save across scenes
                    instance = obj.AddComponent<T>();
                }
                return instance;
            }
        }

        private void OnDestroy()
        {
            if (instance == this)
                instance = null;
        }
    }
}