namespace Test
{
    [TestFixture]
    public class Tests
    {
        private static IEnumerable<List<int[]>> GetTestArrays()
        {
            var tests = new List<int[]>();
            var t1 = Array.Empty<int>();
            var t2 = new int[] { 0 };
            var t3 = new int[] { 1, 0 };
            var t4 = new int[] { 3, 4, 2, 1 };
            var t5 = new int[] { 100, 33, 55, 1, 3, 54, 22, 3, 0, 87, 2 };
            var t6 = new int[] { -1, -5, -4, -3, 1, 2, 3, 4, 5 };

            tests.Add(t1);
            tests.Add(t2);
            tests.Add(t3);
            tests.Add(t4);
            tests.Add(t5);
            tests.Add(t6);

            return new[] { tests };
        }

        [Test]
        [TestCaseSource(nameof(GetTestArrays))]
        public void MergeSortTest(List<int[]> testArrays)
        {
            foreach(var test in testArrays)
            {
                int[] mySorted = MergeSort.MergeSort.Sort(test);
                var t = test.ToList();
                t.Sort();
                int[] itSorted = t.ToArray();

                Assert.That(mySorted.Length, Is.EqualTo(itSorted.Length));
                Assert.That(mySorted, Is.EqualTo(itSorted));
            }
        }
    }
}