using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Duration of a full day/night cycle in real-time seconds.")]
    public float dayDuration = 120f; // Default: 2 minutes for a full rotation

    private void Update()
    {
        if (dayDuration <= 0f) return; // Avoid division by zero

        // Degrees per second for a full 360° rotation
        float rotationSpeed = 360f / dayDuration;

        // Rotate around the X-axis to simulate sun movement
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}