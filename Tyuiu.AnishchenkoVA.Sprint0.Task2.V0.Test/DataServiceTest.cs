using Tyuiu.AnishchenkoVA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageVoid()
        {
            var name = "�����";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("������..., ����", res);
        }
    }
}