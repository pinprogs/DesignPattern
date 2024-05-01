using UnityEngine;

public class StarburgsCoffee : MonoBehaviour
{
    private void Start()
    {
        Beverage beverage = new Espresso();
        Debug.Log($"{beverage.getDescription()}주문은 {beverage.cost()}원 입니다.");

        Beverage beverage2 = new Espresso();
        beverage2 = new Mocha(beverage2);
        Debug.Log($"{beverage2.getDescription()}주문은 {beverage2.cost()}원 입니다.");


        Beverage beverage1 = new HouseBlend();
        beverage1 = new Mocha(beverage1);
        beverage1 = new Mocha(beverage1);

        Debug.Log($"{beverage1.getDescription()}주문은 {beverage1.cost()}원 입니다.");
    }
}
