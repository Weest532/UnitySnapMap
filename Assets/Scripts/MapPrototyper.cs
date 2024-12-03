using UnityEditor; // Required for creating custom editor tools
using UnityEngine; // Provides access to UnityEngine components

public class MapPrototyper : EditorWindow
{
    // Adds a menu item in the Unity Editor under "Tools" to open the prototyper window
    [MenuItem("Tools/Map Prototyper")]
    public static void ShowWindow()
    {
        // Opens or focuses the window, and sets the title to "Map Prototyper"
        GetWindow<MapPrototyper>("Map Prototyper");
    }

    // Called to render and handle the GUI of the custom window
    private void OnGUI()
    {
        // Display a label with bold text style
        GUILayout.Label("Quick Map Prototyping", EditorStyles.boldLabel);

        // Add UI elements (e.g., buttons, sliders, etc.) here
        // Example: Create a button to spawn a predefined map section
        if (GUILayout.Button("Spawn Cube"))
        {
            // Instantiate a basic cube prefab at the origin
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.name = "Prototype Cube";
        }
    }
}
