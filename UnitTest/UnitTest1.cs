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
            //�������`�N�ƶ�
            TestModel.StudentModel studentA = new TestModel.StudentModel
            {
                Name = "�p��",
                Idnumber = "A123456789",
                Mobile = "0912345678"
            };
            TestModel.StudentModel studentB = new TestModel.StudentModel
            {
                Name = "�p��",
                Idnumber = "A123456789",
                Mobile = "0912345678"
            };
            //�o�Ӵ��շ|���� //�]�� �ۦP����ɷ|���HashCode �Ӥ��O����̭����󪺸�Ƥ��e�A�ҥH���G�O���P��
            Assert.AreEqual(studentA, studentB);
        }

        [Test]
        public void TestObjBool()
        {
            //�������`�N�ƶ�
            TestModel.StudentModel studentA = new TestModel.StudentModel
            {
                Name = "�p��",
                Idnumber = "A123456789",
                Mobile = "0912345678"
            };
            TestModel.StudentModel studentB = new TestModel.StudentModel
            {
                Name = "�p��",
                Idnumber = "A123456789",
                Mobile = "0912345678"
            };

            var result = studentA.Equals(studentB);


            Assert.AreEqual(result, true);
        }


    }
}