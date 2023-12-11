using MenuTest.UI;
using UnityEngine;

public class MainMenuWindow : AnimatedWindow
{
    public void OnPlayPressed()
    {
        LoadNewCanvas("Ui/PlayWindow");
    }

    public void OnSettingsPressed()
    {
        LoadNewCanvas("Ui/SettingsWindow");
    }

    private void LoadNewCanvas(string name)
    {
        var window = Resources.Load<GameObject>(name);
        var canvas = FindObjectOfType<Canvas>();
        Instantiate(window, canvas.transform);
    }
}
