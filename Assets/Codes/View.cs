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
        CameraModel.singleton ??= new CameraModel();
        PlayerModel.singleton ??= new PlayerModel();
    }
    void FixedUpdate()
    {
        PlayerModel.singleton.controller.FixedUpdateStatus();
    }
    void Update()
    {
        CameraModel.singleton.controller.UpdateRotation();
        PlayerModel.singleton.controller.UpdateMovement();
    }
}