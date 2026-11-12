
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Duration of a full day in real-world seconds.")]
    [Min(1f)]
    public float dayDuration = 60f;

    void Update()
    {
        // Calculate rotation speed in degrees per second
        float rotationSpeed = 360f / dayDuration;

        // Rotate the light around the X axis
        transform.Rotate(
            Vector3.right,
            rotationSpeed * Time.deltaTime,
            Space.Self
        );
    }
}
