using UnityEngine;

public static class GridSnapping
{
    // Snaps a given position to the nearest point on a grid with the specified grid size
    public static Vector3 SnapToGrid(Vector3 position, float gridSize)
    {
        return new Vector3(
            Mathf.Round(position.x / gridSize) * gridSize, // Snap X coordinate
            Mathf.Round(position.y / gridSize) * gridSize, // Snap Y coordinate
            Mathf.Round(position.z / gridSize) * gridSize  // Snap Z coordinate
        );
    }
}
