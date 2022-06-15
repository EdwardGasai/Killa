using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHidePanel : MonoBehaviour
{
    public void showHidePanel(Canvas obj)
    {
        //fetch our canvas group from the object
        Canvas refCanvasGroup = obj;

        if (obj.enabled)
        {
            obj.enabled = false;
        }
        else
        {
            obj.enabled = true;
        }

    }
}
