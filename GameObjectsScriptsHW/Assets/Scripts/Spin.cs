using UnityEngine;
using UnityEngine.EventSystems;

public class Spin : MonoBehaviour, IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        var dir = eventData.position - (Vector2)transform.position;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
