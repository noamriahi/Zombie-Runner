using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightSystem : MonoBehaviour
{
    [SerializeField] float lightDecay = .1f;
    [SerializeField] float angleDecay = 1f;
    [SerializeField] float minimumAngle = 40f;

    Light mylight;
    private void Start()
    {
        mylight = GetComponent<Light>();
    }
    private void Update()
    {
        DecreaseLightAngle();
        DecreaseLightIntensity();
    }
    public void RestoreLightAngle(float restoreAngle)
    {
        mylight.spotAngle = restoreAngle;
    }
    public void RestoreLightIntensity(float intensityAmount)
    {
        mylight.intensity += intensityAmount;
    }
    private void DecreaseLightAngle()
    {
        if (mylight.spotAngle <= minimumAngle)
        { return; }
        else
        {
            mylight.spotAngle -= angleDecay * Time.deltaTime;
        }
    }
    private void DecreaseLightIntensity()
    {
        mylight.intensity -= lightDecay * Time.deltaTime;
    }
}
