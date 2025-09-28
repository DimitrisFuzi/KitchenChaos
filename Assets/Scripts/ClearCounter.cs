using UnityEngine;

public class ClearCounter : MonoBehaviour
{
   [SerializeField] private KitchenObjectSO kitchenObjectSO;
   [SerializeField] private Transform counterTopPoint;
    public void Interact()
    {
    Debug.Log("Interacted with " + transform.name);
    Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
    kitchenObjectTransform.localPosition = Vector3.zero;

    Debug.Log("Spawned " + kitchenObjectSO.name + " on counter.");
    }
}
