using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] private List<MenuButton> menuButtons;
    void Start()
    {
        foreach (MenuButton m in menuButtons)
        {
            m.button.onClick.AddListener(new UnityEngine.Events.UnityAction(()=>{
                ActivePanel(m.panel);
            }));
        }
    }

    private void ActivePanel(GameObject panel)
    {
        foreach(MenuButton m in menuButtons)
        {
            m.panel.SetActive(false);
        }
        panel.SetActive(true);
    }

    public void OnExitAplicationButtonClicked()
    {
        Application.Quit();
        Debug.Log("The game finished");
    }

    public void OnChangeSceneButtonClicked(int scene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
    }
}

[System.Serializable]
public class MenuButton
{
    public Button button;
    public GameObject panel;
}