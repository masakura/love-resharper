namespace ThirdSamples.Slide29
{
    internal class SafeDelete
    {
        public static void Method1()
        {
            // このメソッドは使われているので、消そうとすると警告が出る
        }

        public static void Method2()
        {
            // このメソッドは使われていないので、警告なしで消せる

            Method1();
        }
    }
}