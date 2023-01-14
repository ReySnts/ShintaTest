using UnityEngine;
public class CameraModel
{
    public static CameraModel singleton = null;
    public CameraController controller = null;
    public GameObject game_object = null;
    public readonly float sensitivity = 150f;
    public float xSpeed = 0f;
    public float ySpeed = 0f;
    public float xAxis = 0f;
    public CameraModel()
    {
        controller = new CameraController();
        game_object = Camera.main.gameObject;
    }
}