using System;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    private int _counter = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {
            throw new NotImplementedException();
        }
        catch (Exception ex)
        {
            Debug.LogException(ex);
        }
    }

    // Update is called once per frame
    void Update()
    {
        _counter++;
        Debug.Log($"Counter: {_counter}");
    }

    private void LateUpdate()
    {
        Debug.LogWarning("Entering to 'LateUpdate' loop with warning.");
    }

    private void FixedUpdate()
    {
        Debug.LogError("Entering to 'FixedUpdate' loop with error.");
    }
}