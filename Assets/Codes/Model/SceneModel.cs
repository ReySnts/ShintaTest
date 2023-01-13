public class SceneModel
{
    public static SceneModel singleton = null;
    public SceneController controller = null;
    public SceneModel()
    {
        controller = new SceneController();
    }
}