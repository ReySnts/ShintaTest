using UnityEngine;
public class View : MonoBehaviour
{
    public static View singleton = null;
    void Awake()
    {
        if (singleton == null) singleton = this;
        else if (singleton != this) Destroy(gameObject);
    }
    void Start()
    {
        CameraModel.controller.Setup();
    }
    void Update()
    {
        CameraModel.singleton.xSpeed = Input.GetAxis("Mouse X") * CameraModel.singleton.sensitivity * Time.deltaTime;
        CameraModel.singleton.ySpeed = Input.GetAxis("Mouse Y") * CameraModel.singleton.sensitivity * Time.deltaTime;
        transform.localRotation = Quaternion.Euler
        (
            Mathf.Clamp
            (
                CameraModel.singleton.xAxis - CameraModel.singleton.ySpeed,
                -90f,
                90f
            ),
            0f,
            0f
        );
    }
}