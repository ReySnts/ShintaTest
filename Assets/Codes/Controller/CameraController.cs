public class CameraController
{
    public void Setup()
    {
        CameraModel.singleton = new CameraModel();
        CameraModel.controller = this;
    }
}