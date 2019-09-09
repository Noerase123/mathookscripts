using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HookSetting : MonoBehaviour {
    public static int releasedLevelStatic = 1;
    public int releasedLevel;
    public string nextLevel;


    void Awake()
    {
        if (PlayerPrefs.HasKey("Hook"))
        {
            releasedLevelStatic = PlayerPrefs.GetInt("Hook", releasedLevelStatic);

        }
    }

    public void ButtonNextLevel()
    {
        SceneManager.LoadScene(nextLevel);

        if (releasedLevelStatic <= releasedLevel)
        {
            releasedLevelStatic = releasedLevel;
            PlayerPrefs.SetInt("Hook", releasedLevelStatic);
        }
    }
}
