using UnityEngine;
using UnityEngine.Events;

public class Environment : MonoBehaviour
{
    private static Environment _instance;
    public static Environment Instance => _instance;

    [SerializeField] private float _globalDrag = 0.0f;
    [SerializeField] private float _globalAngularDrag = 0.0f;

    public float Drag => _globalDrag;
    public float AngularDrag => _globalAngularDrag;

    public UnityEvent OnDragUpdated = new UnityEvent();

    //public delegate void DragUpdate(float drag, float angularDrag);
    //public DragUpdate OnDragUpdated;

    private void Awake()
    {
        if(_instance != null)
        {
            enabled = false;
            return;
        }

        _instance = this;
    }

    public void SetGlobalDrag(float drag, float angularDrag)
    {
        _globalDrag = drag;
        _globalAngularDrag = angularDrag;
        OnDragUpdated.Invoke();
    }
}
