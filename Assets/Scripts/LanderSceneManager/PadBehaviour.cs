using UnityEngine;

public class PadBehaviour : MonoBehaviour
{
    [SerializeField] int _padID;
    public int PadID => _padID;

    public delegate void PlayerCollideHandler(PadBehaviour pad);
    public event PlayerCollideHandler OnPlayerCollide;
    public void InitPad(int padID)
    {
        _padID = padID;
        name = $"Pad {_padID}";
    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag.Equals("Player"))
        {
            OnPlayerCollide.Invoke(this);
        }
    }
}
