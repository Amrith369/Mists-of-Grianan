using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour 
{
 
    public Light sun;
    public GameObject fireFlies;
	public GameObject moon;
	
    public float secondsInFullDay = 120f;
    [Range(0,1)]
    public float currentTimeOfDay = 0;
    [HideInInspector]
    public float timeMultiplier = 1f;
    
    float sunInitialIntensity;
    
    void Start() {
        sunInitialIntensity = sun.intensity;
		fireFlies.SetActive(false);
    }
    
    void Update ()
	{
		UpdateSun ();

		if (currentTimeOfDay <= 0.26 || currentTimeOfDay >= 0.72) 
		{
			moon.SetActive (true);
			fireFlies.SetActive(true);
		} 
		else 
		{
			moon.SetActive (false);
			fireFlies.SetActive(false);
		}
 
        currentTimeOfDay += (Time.deltaTime / secondsInFullDay) * timeMultiplier;
 
        if (currentTimeOfDay >= 1) {
            currentTimeOfDay = 0;
        }
    }
    
    void UpdateSun() {
        sun.transform.localRotation = Quaternion.Euler((currentTimeOfDay * 360f) - 90, 270, 0);
 
        float intensityMultiplier = 1;
        if (currentTimeOfDay <= 0.23f || currentTimeOfDay >= 0.75f) {
            intensityMultiplier = 0;
        }
        else if (currentTimeOfDay <= 0.25f) {
            intensityMultiplier = Mathf.Clamp01((currentTimeOfDay - 0.23f) * (1 / 0.02f));
        }
        else if (currentTimeOfDay >= 0.73f) {
            intensityMultiplier = Mathf.Clamp01(1 - ((currentTimeOfDay - 0.73f) * (1 / 0.02f)));
        }
 
        sun.intensity = sunInitialIntensity * intensityMultiplier;
    }
}