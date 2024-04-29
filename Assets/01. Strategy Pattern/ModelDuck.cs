using UnityEngine;
namespace StrategyPattern
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void display()
        {
            Debug.Log("저는 모형 오리입니다.");
        }
    }
}