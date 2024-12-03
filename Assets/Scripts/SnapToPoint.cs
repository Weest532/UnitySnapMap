using UnityEngine;

public class SnapToPoint : MonoBehaviour
{
    public float snapRange = 1.0f; // Maximum distance within which snapping occurs
    private Transform[] snapPoints; // Array to store all child snap points

    // Called when the script starts or is enabled
    void Start()
    {
        // Get all child Transforms (including the parent itself) to use as snap points
        snapPoints = GetComponentsInChildren<Transform>();
    }

    // Tries to snap a given Transform to the nearest snap point
    public void TrySnap(Transform other)
    {
        foreach (var point in snapPoints)
        {
            // Check if the distance between the object and snap point is within snap range
            if (Vector3.Distance(other.position, point.position) < snapRange)
            {
                // Move the object to the snap point's position and align its rotation
                other.position = point.position;
                other.rotation = point.rotation;
                break; // Stop checking after snapping to the first valid point
            }
        }
    }
}

