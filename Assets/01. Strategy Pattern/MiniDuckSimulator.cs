using UnityEngine;

namespace StrategyPattern
{
    public class MiniDuckSimulator : MonoBehaviour
    {
        private void Start()
        {
            ModelDuckTest();
        }

        void ModelDuckTest()
        {
            Duck model = new ModelDuck();
            model.performFly();
            Debug.Log("모형오리의 나는 행동을 수정합니다...");
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();
        }

        void MallardDuckTest()
        {
            Duck mallard = new MallardDuck();
            mallard.performFly();
            mallard.performQuack();
        }
    }
}
