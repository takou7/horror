using UnityEngine;

public class pickedItem : MonoBehaviour
{
    //このスクリプトは鍵などの拾われるアイテムにアタッチして
    public Item itemData;
    [SerializeField] private AudioClip pickupSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("触ってる");
            inventory inv = other.GetComponent<inventory>();

            if (pickupSound != null)
            {
                AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            }

            inv.itemPick(itemData);
            Destroy(gameObject);
        }
    }
}
