using System;
using System.Collections.Generic; // 使われていない名前空間
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSamplesFoo.Slide11 // 名前空間が正しくない
{
    class NotGood
    {
        public void foo(bool debug_1) // 命名規約違反
        {
            int i = 1; // この変数は使われていない
            bool b = true;
            string s;

            if (!b)
            {
                // ここは常に実行されない無駄なコード
                Console.WriteLine("abc");
            }

            if (debug_1)
            {
                s = "debug";
            }

            Console.WriteLine(s); // 初期化されていない変数の検出
        }
    }
}
