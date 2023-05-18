using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DebugText : MonoBehaviour
{
    public DynamicShip ship;

    [SerializeField] private TextMeshProUGUI text;

    private void Awake()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        text.text = $"Armed: {ship.Armed}\n" +
            $"Flip Mode: {ship.FlipMode}";
    }
}
