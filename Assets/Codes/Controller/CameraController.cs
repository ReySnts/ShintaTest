using UnityEngine;
public class CameraController
{
    CameraModel cameraModel = null;
    float sensitivity = 0f;
    void RotateVertical()
    {
        cameraModel.ySpeed = Input.GetAxis("Mouse Y") * cameraModel.sensitivity * Time.deltaTime;
        cameraModel.xAxis -= cameraModel.ySpeed;
        cameraModel.game_object.transform.localRotation = Quaternion.Euler
        (
            Mathf.Clamp
            (
                cameraModel.xAxis,
                -90f,
                90f
            ),
            0f,
            0f
        );
    }
    void RotateHorizontal()
    {
        cameraModel.xSpeed = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        PlayerModel.singleton.game_object.transform.Rotate(Vector3.up * cameraModel.xSpeed);
    }
    void Setup()
    {
        cameraModel = CameraModel.singleton;
        sensitivity = cameraModel.sensitivity;
    }
    public void UpdateRotation()
    {
        Setup();
        RotateHorizontal();
        RotateVertical();
    }
}