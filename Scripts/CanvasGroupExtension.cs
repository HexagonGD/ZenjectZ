using UnityEngine;

public static class CanvasGroupExtension
{
    public static void SwitchState(this CanvasGroup group, bool enable)
    {
        group.alpha = enable ? 1 : 0;
        group.interactable = enable;
        group.blocksRaycasts = enable;
    }
}