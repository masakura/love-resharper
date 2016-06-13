namespace SecondSamples.Slide18
{
    internal sealed class AutoProperty
    {
        private int _id;

        public int Id // 自動実装プロパティへの変更を提案
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}