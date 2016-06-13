using SecondSamples.Libs;

namespace SecondSamples.Slide18
{
    internal sealed class LinqSamples
    {
        public int GetHogeCustomerScoreTotal(Customer[] customers)
        {
            // LINQ メソッドチェーンに置き換え
            int total = 0;
            for (int i = 0; i < customers.Length; i++)
            {
                if (customers[i].Sex == Sex.Male && customers[i].Age >= 20)
                {
                    total += customers[i].Score;
                }
            }

            return total;
        }
    }
}