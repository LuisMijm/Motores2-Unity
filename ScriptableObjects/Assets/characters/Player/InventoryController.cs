using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{

    [SerializeField]
    private List<ItemData> ItemList_;
    //public KeyCode UseAction_;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!CollectItem()) Debug.Log("No objects found to collect!!!");
        }
        else if (Input.GetButtonDown("Fire2"))
        {
            DropItem();
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            if(ItemList_.Count != 0)
            {
                ItemList_[0].Use(this);
            }
        }
    }

    bool CollectItem()
    {
        DataHolder dataHolderCollected = GameObject.FindObjectOfType<DataHolder>();

        if (dataHolderCollected == null) return false;
        ItemList_.Add(dataHolderCollected.Info_);
        Destroy(dataHolderCollected.gameObject);

        return true;
    }

    bool DropItem()
    {
        int currentItems = ItemList_.Count;
        
        if (currentItems <= 0) return false;

        GameObject goItemDrop = ItemList_[currentItems - 1].ItemPrefab_;
        float dropScale = ItemList_[currentItems - 1].Scale_;

        GameObject go = GameObject.Instantiate<GameObject>(goItemDrop);
        if (go == null) return false;
        go.transform.localScale = new Vector3(dropScale, dropScale, dropScale);



        return true;
    }
}
