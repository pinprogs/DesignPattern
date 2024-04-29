using UnityEngine;
//Duck 클래스는 mono를 상속받아서 그런가 대물림이 되나보다 디버그 되넹
public class MallardDuck : Duck
{
    public MallardDuck()
    {
        quackBehavior = new Quack();
        flyBehavior = new FlyWithWings();
    }

    public override void display()
    {
        Debug.Log("저는 물오리 입니다.");
    }
}
