using UnityEngine;

public class GameController : MonoBehaviour
{
    private MyItem[] _itemsShop;
    private MyItem[] _itemsMy;
    [SerializeField] private int itemCount = 24;
    [SerializeField] private MyItem baseMyItem;
    [SerializeField] private MyItem baseShopItem;
    [SerializeField] private Sprite[] itemSprites;
    
    private void Start()
    {
        CreateItems(out _itemsMy, baseMyItem);
        CreateItems(out _itemsShop, baseShopItem);

        FillItems(_itemsMy);
        FillItems(_itemsShop);
    }

    private void CreateItems(out MyItem[] items, MyItem baseItem)
    {
        items = new MyItem[itemCount];
        items[0] = baseItem;
        for (var i = 1; i < itemCount; i++)
            items[i] = Instantiate(baseItem, baseItem.transform.parent, false);
    }
    
    private void FillItems(MyItem[] items)
    {
        for (var i = 1; i < itemCount; i++)
        {
            var rand = Random.Range(0, 3);
            switch (rand)
            {
                case 0:
                    items[i].Setup(itemSprites[0], OnClicked, 10);
                    break;
                case 1:
                    items[i].Setup(itemSprites[1], OnClicked, 20);
                    break;
                case 2:
                    items[i].Setup(null, OnClicked, 0);
                    break;
            }
        }
    }

    private void OnClicked()
    {
        Debug.Log("kek");
    }
}
