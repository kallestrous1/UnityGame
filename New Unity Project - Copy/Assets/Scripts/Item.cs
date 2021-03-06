using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName ="Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "New Item";
    public Sprite icon = null;
    public bool isDefaultItem = false;
    public ItemType itemType;
    public virtual void Use()
    {
        Debug.Log("using item " + name);
    }
    public void removeFromInventory()
    {
        Inventory.instance.Remove(this);
    }
    public enum ItemType { charm, weapon }
}
