// C# IEnumerator interface reference:
// https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator?view=netframework-4.8

// This solution just saves all the elements.
class PeekingIterator1 {

    private List<int> elems = new List<int>();

    private int index = 0;

    // iterators refers to the first element of the array.
    public PeekingIterator(IEnumerator<int> iterator) 
    {
        elems.Clear();
        do
        {
            elems.Add(iterator.Current);
        } while (iterator.MoveNext());
    }
    
    // Returns the next element in the iteration without advancing the iterator.
    public int Peek() 
    {
        return elems[index];
    }
    
    // Returns the next element in the iteration and advances the iterator.
    public int Next() 
    {
        return elems[index++];
    }
    
    // Returns false if the iterator is refering to the end of the array of true otherwise.
    public bool HasNext() 
    {
		return index < elems.Count;
    }
}


class PeekingIterator2 {
    private IEnumerator<int> _iter;

    private int _current;

    private bool _hasNext;

    // iterators refers to the first element of the array.
    public PeekingIterator(IEnumerator<int> iterator) 
    {
        _iter = iterator;
        _current = _iter.Current;
        _hasNext = true;
    }
    
    // Returns the next element in the iteration without advancing the iterator.
    public int Peek() 
    {
        return _current;
    }
    
    // Returns the next element in the iteration and advances the iterator.
    public int Next() 
    {
        int t = _current;    
        _hasNext = _iter.MoveNext();
        _current = _iter.Current;
        return t;
    }
    
    // Returns false if the iterator is refering to the end of the array of true otherwise.
    public bool HasNext() 
    {
        return _hasNext;
    }
}