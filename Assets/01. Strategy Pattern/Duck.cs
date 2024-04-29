using UnityEngine;

namespace StrategyPattern
{
    public abstract class Duck
    {
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;

        public Duck()
        {
            //비엇슴
        }

        public abstract void display();

        public void setFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void setQuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }

        //ㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋ
        public void swin()
        {
            Debug.Log("모든 오리는 물에 뜹니다. 가짜 오리도 뜨죠.");
        }
    }

    public interface FlyBehavior
    {
        public void fly();
    }

    public class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            Debug.Log("날고 있다는");
        }
    }

    public class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            Debug.Log("난 못날아..");
        }
    }

    public class FlyRocketPowered : FlyBehavior
    {
        public void fly()
        {
            Debug.Log("이 오리는 로켓추진으로 날아갑니다.");
        }
    }

    public interface QuackBehavior
    {
        public void quack();
    }

    public class Quack : QuackBehavior
    {
        public void quack()
        {
            Debug.Log("꽤애애애액!!!!!!!!!!");
        }
    }

    public class MuteQuack : QuackBehavior
    {
        public void quack()
        {
            Debug.Log("~~조용~~...");
        }
    }

    public class Squeak : QuackBehavior
    {
        public void quack()
        {
            Debug.Log("쀽");
        }
    }
}