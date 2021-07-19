using UnityEngine.UI;

interface IDataItemDisplayer : ILayoutElement
{
    void SetData(DataItem dataItem);
}