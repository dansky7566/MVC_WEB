using NUnit.Framework;
using MVC_WEB.Models;
namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestObj()
        {
            //物件比較注意事項
            TestModel.StudentModel studentA = new TestModel.StudentModel
            {
                Name = "小明",
                Idnumber = "A123456789",
                Mobile = "0912345678"
            };
            TestModel.StudentModel studentB = new TestModel.StudentModel
            {
                Name = "小明",
                Idnumber = "A123456789",
                Mobile = "0912345678"
            };
            //這個測試會失敗 //因為 相同比較時會比較HashCode 而不是比較裡面物件的資料內容，所以結果是不同的
            Assert.AreEqual(studentA, studentB);
        }

        [Test]
        public void TestObjBool()
        {
            //物件比較注意事項
            TestModel.StudentModel studentA = new TestModel.StudentModel
            {
                Name = "小明",
                Idnumber = "A123456789",
                Mobile = "0912345678"
            };
            TestModel.StudentModel studentB = new TestModel.StudentModel
            {
                Name = "小明",
                Idnumber = "A123456789",
                Mobile = "0912345678"
            };

            var result = studentA.Equals(studentB);


            Assert.AreEqual(result, true);
        }


    }
}