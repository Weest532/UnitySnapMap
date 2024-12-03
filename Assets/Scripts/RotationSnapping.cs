using UnityEngine;

public static class RotationSnapping
{
    // Snaps a given rotation to the nearest angle increment
    public static Quaternion SnapRotation(Quaternion rotation, float angleIncrement)
    {
        // Get the rotation's Euler angles
        Vector3 euler = rotation.eulerAngles;

        // Round each axis to the nearest increment
        euler.x = Mathf.Round(euler.x / angleIncrement) * angleIncrement;
        euler.y = Mathf.Round(euler.y / angleIncrement) * angleIncrement;
        euler.z = Mathf.Round(euler.z / angleIncrement) * angleIncrement;

        // Return the snapped rotation as a Quaternion
        return Quaternion.Euler(euler);
    }
}
