using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GammaSlider : MonoBehaviour
{
    public float rgbValue = 0.5f;

    public void ChangeLight(float newGamma)
    {
        rgbValue = newGamma;
        RenderSettings.ambientLight = new Color(rgbValue, rgbValue, rgbValue, 1);
    }

}
