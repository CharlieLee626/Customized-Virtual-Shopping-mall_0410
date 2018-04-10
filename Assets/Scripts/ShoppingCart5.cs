using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoppingCart5 : MonoBehaviour
{

    public List<GameObject> BoughtItems = new List<GameObject>();
    public static float totalPriceOnUI;
    public UI shoppingcartUI;
    public Text txt;
    public static ShoppingCart5 Instance;

    public void Init()
    {
    }

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        print("Awake");
    }

    // Use this for initialization
    void Start()
    {
        print("Start");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        totalPriceOnUI = countPrice();
        print("Current cost: " + totalPriceOnUI);
    }

    float countPrice() // show something with UI, must have sth interactiong with the UI
    {
        float totalPrice = 0;
        foreach (GameObject entry in BoughtItems)
        {
            if (entry.GetComponent<Item>() == null)
                return 0;
            totalPrice += entry.GetComponent<Item>().price;
            //            print("Current cost : " + totalPrice);
        }
        return totalPrice;
    }

    void OnTriggerEnter(Collider other)
    {
        Item entry = other.GetComponent<Item>();

        if (other.GetComponent<Item>() == null)
            return;
        if (other.GetComponent<Item>().InShoppingCart)
            return;

        other.GetComponent<Item>().InShoppingCart = true;

        BoughtItems.Add(other.gameObject);
        print(other.name);

        print("A " + entry.ItemType.ToString() + " in the shopping cart!!!");

        CheckOutPanel.Instance.AddItem(entry);
        CheckOutPanel1.Instance.AddItem(entry);
        CheckOutPanel2.Instance.AddItem(entry);
        CheckOutPanel3.Instance.AddItem(entry);
        CheckOutPanel4.Instance.AddItem(entry);
        CheckOutPanel5.Instance.AddItem(entry);
        CheckOutPanel6.Instance.AddItem(entry);
        CheckOutPanel7.Instance.AddItem(entry);
        CheckOutPanel8.Instance.AddItem(entry);

    }

    void OnTriggerExit(Collider other)
    {
        Item entry = other.GetComponent<Item>();

        if (other.GetComponent<Item>() == null)
            return;
        if (!other.GetComponent<Item>().InShoppingCart)
            return;

        other.GetComponent<Item>().InShoppingCart = false;

        BoughtItems.Remove(other.gameObject);


        print("A " + entry.ItemType.ToString() + " out the shopping cart!!!");

        CheckOutPanel.Instance.RemoveItem(entry);
        CheckOutPanel1.Instance.RemoveItem(entry);
        CheckOutPanel2.Instance.RemoveItem(entry);
        CheckOutPanel3.Instance.RemoveItem(entry);
        CheckOutPanel4.Instance.RemoveItem(entry);
        CheckOutPanel5.Instance.RemoveItem(entry);
        CheckOutPanel6.Instance.RemoveItem(entry);
        CheckOutPanel7.Instance.RemoveItem(entry);
        CheckOutPanel8.Instance.RemoveItem(entry);

    }

    /*
    void UI() // show something with UI, must have sth interactiong with the UI
    {
        float totalPrice = 0;

        foreach (GameObject entry in BoughtItems)
        {
            totalPrice += entry.GetComponent<Item>().price;
        }
    }
    */

    public void moneyCheck()
    {
        string items = "";
        items.Replace("<$NEWLINE$>", "\n");
        string previousName = "";
        int counter_forItem = 0;

        txt = shoppingcartUI.GetComponent<Text>();
        //txt.text = "CCCCCCCCCCCCCCCheck";
        foreach (GameObject entry in BoughtItems)
        {
            if (entry.name != previousName)
            {
                if (counter_forItem == 0)
                {
                    items += entry.name;
                }
                else
                {
                    items += ", " + entry.name;
                }
            }
            counter_forItem++;
            previousName = entry.name;
        }

        items += "\n";

        items += "Total Price : " + countPrice();

        txt.text = items;
    }

}



