using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Reaktion;
using Kvant;

public class StreamThrottleGear : MonoBehaviour
{
    public ReaktorLink reaktor;
    public Stream stream;
    public float scale; 

    void Awake()
    {
        reaktor.Initialize(this);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Reactor Output :  Linear " + reaktor.Output + " " + DecibelToLinear(reaktor.Output));
        stream.throttle = scale * DecibelToLinear(reaktor.Output);
        stream.UpdateKernelShader(); 
    }

    private float DecibelToLinear(float dB)
    {
        float linear = Mathf.Pow(10.0f, dB / 20.0f);

        return linear;
    }
}
