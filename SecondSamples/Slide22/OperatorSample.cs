using SecondSamples.Libs;

namespace SecondSamples.Slide22
{
    internal sealed class OperatorSample
    {
        public string GetDisplayText(string s)
        {
            // 三項演算子への置きかえ
            if (string.IsNullOrEmpty(s))
            {
                return "(Empty)";
            }
            else
            {
                return s;
            }
        }

        public string GetDisplayText(Customer customer)
        {
            // ?? 演算子への置き換え
            if (customer.Name != null)
            {
                return customer.Name;
            }
            return "(Empty)";
        }

        public string GetBelongText(Customer customer)
        {
            // ?. 演算子への置き換え
            if (customer != null && customer.Belong != null)
            {
                return customer.Belong.Name;
            }

            return null;
        }
    }
}