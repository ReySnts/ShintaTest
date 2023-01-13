using UnityEngine;
public class PauseMenuModel
{
    public static PauseMenuModel singleton = null;
    public PauseMenuController controller = null;
    public GameObject game_object = null;
    public bool hasDelayed = false;
    public PauseMenuModel()
    {
        controller = GameObject.Find("Controller").GetComponent<PauseMenuController>();
        game_object = GameObject.Find("Canvas");
    }
}