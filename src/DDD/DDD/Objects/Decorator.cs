namespace DDD.Objects
{
    // 1. 同じインターフェースの実装にする
    public abstract class Decorator : IComponent
    {
        // 2. 同じインターフェースを保持する
        protected IComponent _child;

        // 3. コンストラクタで子階層を受ける
        public Decorator(IComponent child)
        {
            _child = child;
        }

        // 4. _childを使って実装（拡張）する
        public string GetData()
        {
            return GetDataSub();
        }

        protected abstract string GetDataSub();
    }
}
