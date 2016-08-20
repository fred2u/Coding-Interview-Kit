using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coding_Interview_Kit.TwoSum.UnitTests
{
    [TestClass]
    public class TwoSumTests
    {

        [TestMethod]
        public void TwoSum_Find_Expect_True_For_Existing_Sum()
        {
            var twoSum = new TwoSum();
            twoSum.Add(1);
            twoSum.Add(5);
            twoSum.Add(3);

            Assert.IsTrue(twoSum.Find(4));
        }

        [TestMethod]
        public void TwoSum_Find_Expect_False_When_The_Sum_Does_Not_Exist()
        {
            var twoSum = new TwoSum();
            twoSum.Add(1);
            twoSum.Add(5);
            twoSum.Add(3);

            Assert.IsFalse(twoSum.Find(7));
        }

        [TestMethod]
        public void TwoSum_Find_Expect_True_When_The_Sum_Is_The_Double_Of_One_Existing_Number_Added_Twice()
        {
            var twoSum = new TwoSum();
            twoSum.Add(3);
            twoSum.Add(3);

            Assert.IsTrue(twoSum.Find(6));
        }

        [TestMethod]
        public void TwoSum_Find_Expect_True_When_The_Sum_Is_The_Double_Of_One_Existing_Number_Added_Three_Times()
        {
            var twoSum = new TwoSum();
            twoSum.Add(3);
            twoSum.Add(3);
            twoSum.Add(3);

            Assert.IsTrue(twoSum.Find(6));
        }

        [TestMethod]
        public void TwoSum_Find_Expect_False_When_The_Sum_Is_The_Double_Of_One_Existing_Number_Added_Once()
        {
            var twoSum = new TwoSum();
            twoSum.Add(1);
            twoSum.Add(3);

            Assert.IsFalse(twoSum.Find(6));
        }

        [TestMethod]
        public void TwoSum_Find_Expect_True_For_Existing_Sum_Of_Negative_Numbers()
        {
            var twoSum = new TwoSum();
            twoSum.Add(-1);
            twoSum.Add(5);
            twoSum.Add(-3);

            Assert.IsTrue(twoSum.Find(-4));
        }

        [TestMethod]
        public void TwoSum_Find_With_Negative_And_Positive_numbers_and_Positive_Sum_Expected()
        {
            var twoSum = new TwoSum();
            twoSum.Add(-1);
            twoSum.Add(5);

            Assert.IsTrue(twoSum.Find(4));
        }

        [TestMethod]
        public void TwoSum_Find_With_Negative_And_Positive_numbers_and_Negative_Sum_Expected()
        {
            var twoSum = new TwoSum();
            twoSum.Add(-4);
            twoSum.Add(2);

            Assert.IsTrue(twoSum.Find(-2));
        }

        [TestMethod]
        public void TwoSum_Find_Expect_False_When_The_Sum_Overflows_with_Positive_Integer()
        {
            var twoSum = new TwoSum();
            twoSum.Add(int.MaxValue);
            twoSum.Add(int.MaxValue);

            Assert.IsFalse(twoSum.Find(-2));
        }

        [TestMethod]
        public void TwoSum_Find_Expect_False_When_The_Sum_Overflows_with_Negative_Integer()
        {
            var twoSum = new TwoSum();
            twoSum.Add(int.MinValue);
            twoSum.Add(int.MinValue);

            Assert.IsFalse(twoSum.Find(0));
        }

    }
}
