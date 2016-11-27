using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    public Button[] lvlButtons;
    public int lvlCount;
    public int prefsLvl;

    void Start()
    {
        lvlCount = lvlButtons.Length;
        prefsLvl = PlayerPrefs.GetInt("count");
        if (lvlCount <= PlayerPrefs.GetInt("count"))
        {
            foreach (Button button in lvlButtons)
            {
                button.interactable = true;
            }
        }
        else
        {
            for (int i = 0; i < PlayerPrefs.GetInt("count") + 1; i++)
            {
                lvlButtons[i].interactable = true;
            }
        }

    }
}
