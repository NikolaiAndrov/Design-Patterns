namespace IteratorPattern.Contracts
{
    public interface IIterator<T>
    {
        public bool HasNext();
        public void Next();
        public void Reset();
        public T Current();
    }
}
