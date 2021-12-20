using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPulse : MonoBehaviour
{
    public Light light;
    public float lightMin;
    public float lightMax;
    public float Speed;
    public float lightValue;
    void Update()
    {
        if (light.intensity > lightMax || light.intensity < lightMin)
            lightValue = Random.Range(lightMin, lightMax);
        if (light.intensity < lightValue)
        {
            light.intensity += Speed * Time.deltaTime;
            return;
        }

        if (light.intensity > lightValue)
        {
            light.intensity -= Speed * Time.deltaTime;
            return;
        }
    }
}
