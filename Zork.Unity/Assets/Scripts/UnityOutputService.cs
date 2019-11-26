using System.Collections.Generic;
using UnityEngine;
using Zork;
using TMPro;

public class UnityOutputService : MonoBehaviour, IOutputService
{
    public UnityOutputService()
    {
        mTextLines = new List<GameObject>();
    }
    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public void Write(string value)
    {
        throw new System.NotImplementedException();
    }

    public void Write(object value)
    {
        throw new System.NotImplementedException();
    }

    public void WriteLine(string value)
    {
        if(mTextLines.Count >= MaxTextLines)
        {
            Destroy(mTextLines[0]);
            mTextLines.RemoveAt(0);
        }

        var textLine = Instantiate(TextLinePrefab);
        textLine.transform.SetParent(OutputTextContainer, false);
        textLine.text = value;
        mTextLines.Add(textLine.gameObject);
    }

    public void WriteLine(object value) => WriteLine(value.ToString());

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private List<GameObject> mTextLines;

    [SerializeField]
    private TextMeshProUGUI TextLinePrefab;

    [SerializeField]
    private Transform OutputTextContainer;

    [SerializeField]
    private int MaxTextLines = 60;
}
