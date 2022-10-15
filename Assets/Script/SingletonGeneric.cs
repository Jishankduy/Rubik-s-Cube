using UnityEngine;

public class SingletonGeneric<T> : MonoBehaviour where T : SingletonGeneric<T>
{
    // Start is called before the first frame update
    public static T instance;
    public static T Instance { get { return instance; } }

    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance = (T)this;
        }
        else
        {
            Destroy(this);
        }
    }
}
