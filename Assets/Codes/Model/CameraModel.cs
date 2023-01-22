using UnityEngine;
public class CameraModel
{
    public static CameraModel singleton = null;
    public CameraController controller = new CameraController();
    public GameObject game_object = Camera.main.gameObject;
    public float sensitivity = 150f;
    public float xSpeed = 0f;
    public float ySpeed = 0f;
    public float xAxis = 0f;
}