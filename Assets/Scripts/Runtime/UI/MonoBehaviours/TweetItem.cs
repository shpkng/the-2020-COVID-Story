using TMPro;
using UnityEngine;
class TweetItem : MonoBehaviour, IDataItemDisplayer
{
    [SerializeField]private TMP_Text txtName, txtContent,txtDevice;
    public void SetData(DataItem dataItem)
    {
        if (!(dataItem is Tweet tweet))
            return;
        
    }
}
