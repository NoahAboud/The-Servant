using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item; // ScriptableObject reference

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Inventory.instance.Add(item);
            Destroy(gameObject); // removes the 3D object from the world
        }
    }
}