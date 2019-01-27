using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{
    // The ink story that we're wrapping
    Story _inkStory;

    Queue<string> sentences;
    string savedStoryState;

    // Set this file to your compiled json asset
    public TextAsset inkAsset;
    public Text narrativeText;
    public GameObject choices;
    // public GameManager gameManager;
    SoundManager soundManager;
    GameSceneManager gameSceneManager;

    // Start is called before the first frame update
    void Awake()
    {
        soundManager = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
        gameSceneManager = GameObject.FindGameObjectWithTag("GameSceneManager").GetComponent<GameSceneManager>();

        DisableChoices();
        _inkStory = new Story(inkAsset.text);
        sentences = new Queue<string>();

        BindFunctions();
    }

    void Start()
    {
        StartDialogue();
    }

    void StartDialogue()
    {
        sentences.Clear();
        narrativeText.text = "";

        while (_inkStory.canContinue)
        {
            narrativeText.text += _inkStory.Continue();
        }

        if (_inkStory.currentChoices.Count > 0)
        {
            ShowChoices(_inkStory.currentChoices);
        }
    }

    void ShowChoices(List<Choice> choicesList)
    {
        for (int i = 0; i < choicesList.Count; i++)
        {
            choices.transform.GetChild(i).gameObject.transform
                .Find("Text").gameObject.GetComponent<Text>().text = choicesList[i].text;
            choices.transform.GetChild(i).gameObject.SetActive(true);
        }
    }

    void DisableChoices()
    {
        foreach (Transform item in choices.transform)
        {
            item.gameObject.SetActive(false);
        }
    }

    public void MakeChoice(int idx)
    {
        //soundManager.PlayAgentImmoReaction();
        _inkStory.ChooseChoiceIndex(idx);
        DisableChoices();
        
        StartDialogue();
    }

    void SaveStoryState()
    {
        savedStoryState = _inkStory.state.ToJson();
    }

    void BindFunctions()
    {
        _inkStory.BindExternalFunction("loadQuestLevel1", () =>
        {
            Debug.Log("load quest");
            gameSceneManager.LoadQuestLevel1();
            soundManager.PlayPlanetCraft();

        });

        _inkStory.BindExternalFunction("playVoiceAlien1", () =>
        {
            soundManager.PlayVoiceAlien1();

        });

        _inkStory.BindExternalFunction("gameOver", () =>
        {
            gameSceneManager.LoadMainMenu();
            Debug.Log("back to Menu");

        });
    }
}
