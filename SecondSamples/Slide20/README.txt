下の文章をスタックトレース込みでコピペして、ReSharper -> Windows -> Stack Traces

もしかしたら、パスが違うなどでうまくジャンプできないかも知れません。そのときは、StackTraceSamples.cs を開いて、テストを実行してください。テスト結果にスタックトレースが出力されます。

----
バグ報告です。

なんか適当にいじってたら例外出たけどなんで?

System.Exception : 種類 'System.Exception' の例外がスローされました。
   場所 SecondSamples.StackTraceSamples.C() 場所 C:\Users\masakura\Documents\Visual Studio 15\Projects\LoveReSharper\SecondSamples\Slide20\StackTraceSamples.cs:行 22
   場所 SecondSamples.StackTraceSamples.B() 場所 C:\Users\masakura\Documents\Visual Studio 15\Projects\LoveReSharper\SecondSamples\Slide20\StackTraceSamples.cs:行 17
   場所 SecondSamples.StackTraceSamples.A() 場所 C:\Users\masakura\Documents\Visual Studio 15\Projects\LoveReSharper\SecondSamples\Slide20\StackTraceSamples.cs:行 11
   場所 SecondSamples.StackTraceSamples.TestMethod() 場所 C:\Users\masakura\Documents\Visual Studio 15\Projects\LoveReSharper\SecondSamples\Slide20\StackTraceSamples.cs:行 28
