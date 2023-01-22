using UnityEngine;
using System.IO;
public class SceneController
{
    public void OnEnableAt(int buildIndex)
    {
        switch(buildIndex)
        {
            case 0:
                break;
            default:
                CameraModel.singleton = new CameraModel();
                CameraModel.singleton.controller.Setup();
                PlayerModel.singleton = new PlayerModel();
                PlayerModel.singleton.controller.Setup();
                PauseMenuModel.singleton = new PauseMenuModel();
                PauseMenuModel.singleton.controller.Continue();
                break;
        }
    }
    public void StartAt(int buildIndex)
    {
        string toJson = null;
        switch(buildIndex)
        {
            case 0:
                break;
            default:
                toJson = JsonUtility.ToJson(CameraModel.singleton);
                File.WriteAllText
                (
                    Application.dataPath + "/JSON/Camera.json",
                    toJson
                );
                toJson = JsonUtility.ToJson(PlayerModel.singleton);
                File.WriteAllText
                (
                    Application.dataPath + "/JSON/Player.json",
                    toJson
                );
                toJson = JsonUtility.ToJson(PauseMenuModel.singleton);
                File.WriteAllText
                (
                    Application.dataPath + "/JSON/PauseMenu.json",
                    toJson
                );
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
                PlayerModel.singleton.controller.FixedUpdateLanding();
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
                CameraModel.singleton.controller.UpdateRotation();
                PlayerModel.singleton.controller.UpdateMovement();
                PauseMenuModel.singleton.controller.UpdateDelay();
                break;
        }
    }
}