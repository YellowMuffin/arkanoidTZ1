using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ui : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            text.text = "Zmieniony tekst";
            text.fontSize = 120;
            text.fontStyle = FontStyles.Bold;
            text.alignment = TextAlignmentOptions.Right;
        }
    }
}
