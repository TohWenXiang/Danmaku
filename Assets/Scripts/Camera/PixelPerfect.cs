using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelPerfect : MonoBehaviour
{
    public int PPU = 64;
    public int scale = 1;

    private void Awake()
    {
        SetCameraSize(PPU, scale, Screen.currentResolution.height);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetCameraSize(int PPU, int scale, int verticalHeight)
    {
        Camera.main.orthographicSize = ((verticalHeight * 0.5f) / PPU) * scale;
    }
}
