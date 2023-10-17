using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{

    [SerializeField]
    private List<ItemData> ItemList_;
    //public KeyCode UseAction_;

    public Charactercontroller characterController_;

    public ItemData healSkill_;
    public ItemData fireballSkill_;


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
                ItemList_[0].Use(this, characterController_);
            }
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            fireballSkill_.Use(this, characterController_);
        }
        
        if(Input.GetKeyDown(KeyCode.W))
        {
            // GameObject goItemDrop = ItemList_[currentItems - 1].ItemPrefab_;
            // GameObject healSkill_ = GameObject.Instantiate<GameObject>(GameObject.ItemPrefab_);
            // if (go == null) return false;
            healSkill_.Use(this, characterController_);
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
