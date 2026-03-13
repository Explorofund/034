using UnityEngine;

[CreateAssetMenu(fileName = "GameConfig", menuName = "Game/Game Config")]
public class GameConfig : ScriptableObject
{
    private static GameConfig _instance;

    public static GameConfig Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = Resources.Load<GameConfig>("GameConfig");
                if (_instance == null)
                    Debug.LogError("GameConfig asset not found in Resources folder. " +
                                   "Right-click in Assets/Resources and select Create > Game > Game Config.");
            }
            return _instance;
        }
    }

    [Header("Levels")]
    public int TotalLevelNum = 3;
    public int InitialUnlockedLevelNum = 1;

    [Header("Scene Names")]
    public string LevelSelectSceneName = "LevelSelect";
    public string LevelScenePrefix = "Level_";

    [Header("Camera")]
    public float MaxHorizontalSpan = 0.4f;
    public float MaxVerticalSpan = 0.4f;

    public string GetLevelSceneName(int index) => $"{LevelScenePrefix}{index}";
}
