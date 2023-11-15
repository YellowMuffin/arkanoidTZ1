using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    [SerializeField] float ScreenWidthInUnits = 16f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseposinunits = Input.mousePosition.x / Screen.width * ScreenWidthInUnits;
        Vector2 paddlepos = new Vector2(transform.position.x, transform.position.y);
        paddlepos.x = Mathf.Clamp(mouseposinunits, minX, maxX);
        transform.position = paddlepos;
    }
}
