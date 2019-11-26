using UnityEngine;
using Zork;

public class GameManager : MonoBehaviour
{
    void Awake()
    {
        TextAsset gameJsonAsset = Resources.Load<TextAsset>(ZorkGameFileAssetName);
        Game.Start(gameJsonAsset.text, InputService, OutputService);
        Game.Instance.CommandManager.PerformCommand(Game.Instance, "LOOK");
    }

    void Start()
    {
        
    }

    void Update()
    {
    }

    public string ZorkFilename = @"Assets\Zork.json";
    public UnityOutputService OutputService;
    

    [SerializeField]
    private string ZorkGameFileAssetName = "Zork";

    [SerializeField]
    private UnityInputService InputService;

    //[SerializeField]
    //private UnityOutputService OutputService;
}
