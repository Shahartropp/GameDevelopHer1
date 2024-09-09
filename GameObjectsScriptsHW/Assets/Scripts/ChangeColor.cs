using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour, IPointerClickHandler
{
    Image image;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (image == null) image = GetComponent<Image>();

        image.color = Random.ColorHSV();
    }
}
