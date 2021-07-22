using TMPro;
using UnityEngine;
using UnityEngine.UI;

class TweetItem : MonoBehaviour, IDataItemDisplayer
{
    [SerializeField] private TMP_Text txtName, txtContent, txtDevice;
    [SerializeField] private PicButton[] pics; 
    private int id;

    public void SetData(DataItem dataItem)
    {
        if (!(dataItem is Tweet tweet))
            return;
        if (id == tweet.id)
            return;
        id = tweet.id;
        txtName.text = tweet.sender.GetPerson().userName;
        foreach (var contentId in tweet.contentIds)
        {
            
        }
    }

    public void CalculateLayoutInputHorizontal()
    {
    }

    public void CalculateLayoutInputVertical()
    {
    }

    public float minWidth => 0;
    public float preferredWidth { get; }
    public float flexibleWidth { get; }
    public float minHeight => 0;
    public float preferredHeight { get; }
    public float flexibleHeight { get; }
    public int layoutPriority { get; }
}