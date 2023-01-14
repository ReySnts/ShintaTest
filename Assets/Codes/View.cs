using UnityEngine;
using UnityEngine.SceneManagement;
public class View : MonoBehaviour
{
    public static View singleton = null;
    int buildIndex = 0;
    void Awake()
    {
        if (singleton == null) singleton = this;
        else if (singleton != this) Destroy(gameObject);
    }
    void OnEnable()
    {
        SceneModel.singleton = new SceneModel();
        buildIndex = SceneManager.GetActiveScene().buildIndex;
        SceneModel.singleton.controller.OnEnableAt(buildIndex);
    }
    void FixedUpdate()
    {
        SceneModel.singleton.controller.FixedUpdateAt(buildIndex);
    }
    void Update()
    {
        SceneModel.singleton.controller.UpdateAt(buildIndex);
    }
}