namespace NameSorter

{
    public interface IComparator<E>
    {
        int Compare(E arg1, E arg2);
    }
}