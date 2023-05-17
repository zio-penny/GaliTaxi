using UnityEngine;

public class PadBehaviour : MonoBehaviour
{
    [SerializeField] int _padID;
    [SerializeField] bool _playerLanded;
    public int PadID => _padID;
    public void InitPad(int padID)
    {
        _padID = padID;
        name = $"Pad {_padID}";
    }
}
