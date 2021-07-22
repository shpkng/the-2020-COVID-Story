// Author: wuchenyang(shpkng@gmail.com)

using UnityEngine;
using UnityEngine.UI;


public enum PicButtonType
{
    Pic,
    Vid
}

public class PicButton : MonoBehaviour
{
    [SerializeField] private Image img;
    private PicButtonType type;
    private int spriteId, resId;

    public void SetUp(int spriteId, PicButtonType buttonType, int id)
    {
        this.spriteId = spriteId;
        type = buttonType;
        resId = id;
    }

    public void Execute()
    {
        if (type == PicButtonType.Pic)
        {
        }
        else if (type == PicButtonType.Vid)
        {
            return;
        }
    }
}