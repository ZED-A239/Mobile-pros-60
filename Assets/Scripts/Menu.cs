using UnityEngine;
using UnityEngine.UIElements;

public class Menu : MonoBehaviour
{
    private UIDocument uiDocument;

    private VisualElement mainMenu;
    private VisualElement optionsMenu;

    private Button optionsButton;
    private Button backButton;
    private Button musicButton;
    private Button soundsButton;


    void Awake()
    {
        uiDocument = GetComponent<UIDocument>();

        var root = uiDocument.rootVisualElement;

        mainMenu = root.Q<VisualElement>("MainMenu");
        optionsMenu = root.Q<VisualElement>("OptionsMenu");

        optionsButton = root.Q<Button>("OptionsButton");
        backButton = root.Q<Button>("BackButton");
        musicButton = root.Q<Button>("MusicButton");
        soundsButton = root.Q<Button>("SoundButton");

        musicButton.style.unityBackgroundImageTintColor = new Color(1, 1, 1);
        soundsButton.style.unityBackgroundImageTintColor = new Color(1, 1, 1);

        optionsButton.clicked += () => ShowMenu(optionsMenu);
        backButton.clicked += () => ShowMenu(mainMenu);

        musicButton.clicked += () =>
        {
            if (musicButton.style.unityBackgroundImageTintColor.value.a == 1)
            {
                musicButton.style.unityBackgroundImageTintColor = new Color(1, 1, 1, 0);
            }
            else
            {
                musicButton.style.unityBackgroundImageTintColor = new Color(1, 1, 1);
            }
        };

        soundsButton.clicked += () =>
        {
            if (soundsButton.style.unityBackgroundImageTintColor.value.a == 1)
            {
                soundsButton.style.unityBackgroundImageTintColor = new Color(1, 1, 1, 0);
            }
            else
            {
                soundsButton.style.unityBackgroundImageTintColor = new Color(1, 1, 1);
            }
        };





    }

    void ShowMenu(VisualElement menu)
    {
        mainMenu.style.display = DisplayStyle.None;
        optionsMenu.style.display = DisplayStyle.None;

        menu.style.display = DisplayStyle.Flex;

    }

}
