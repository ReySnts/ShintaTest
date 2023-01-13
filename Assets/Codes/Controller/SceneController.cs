public class SceneController
{
    public void AwakeAt(int buildIndex)
    {
        switch(buildIndex)
        {
            case 0:
                break;
            default:
                PauseMenuModel.singleton ??= new PauseMenuModel();
                PauseMenuModel.singleton.game_object.SetActive(false);
                CameraModel.singleton ??= new CameraModel();
                PlayerModel.singleton ??= new PlayerModel();
                break;
        }
    }
    public void FixedUpdateAt(int buildIndex)
    {
        switch(buildIndex)
        {
            case 0:
                break;
            default:
                PlayerModel.singleton.controller.FixedUpdateStatus();
                break;
        }
    }
    public void UpdateAt(int buildIndex)
    {
        switch(buildIndex)
        {
            case 0:
                break;
            default:
                PauseMenuModel.singleton.controller.UpdateDelay();
                CameraModel.singleton.controller.UpdateRotation();
                PlayerModel.singleton.controller.UpdateMovement();
                break;
        }
    }
}