using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private RectTransform _container;

    public void AddButton(Button button)
    {
        button.transform.SetParent(_container);
    }
}