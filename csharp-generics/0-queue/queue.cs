using System;

/// <summary>
/// Class named Queue
/// </summary>
class Queue<T>
{
    /// <summary>
    /// method that returns the queues type.
    /// </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

}