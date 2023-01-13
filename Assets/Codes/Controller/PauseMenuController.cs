using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenuController : MonoBehaviour
{
    public void Pause()
    {
        PauseMenuModel.singleton.hasDelayed = true;
        PauseMenuModel.singleton.game_object.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
    }
    public void Continue()
    {
        PauseMenuModel.singleton.hasDelayed = false;
        PauseMenuModel.singleton.game_object.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
    }
    public void UpdateDelay()
    {
        if 
        (
            Input.GetKeyDown(KeyCode.Escape)
        )
        {
            if (!PauseMenuModel.singleton.hasDelayed) Pause();
            else Continue();
        }
    }
    public void Exit()
    {
        SceneManager.LoadScene(0);
    }
}