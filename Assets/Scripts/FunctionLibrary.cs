using UnityEngine;
using static UnityEngine.Mathf;

public static class FunctionLibrary {
    public static float Wave(float x, float t) {
        return Sin(PI * (x + t));
    }

    public static float MultiWave(float x, float t) {
        float y = Sin(PI * (x + .5f * t));
        y += Sin(2f * PI * (x + t)) * .5f;
        return y * (2f / 3f);
    }

    public static float Ripple(float x, float t) {
        float d = Abs(x);
        return d;
    }

}
