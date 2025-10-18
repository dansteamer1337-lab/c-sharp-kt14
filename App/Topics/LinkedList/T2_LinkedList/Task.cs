namespace App.Topics.LinkedList.T2_LinkedList;

public static class LinkedListTasks
{
    public static System.Collections.Generic.LinkedList<int>
        RemoveDuplicates(System.Collections.Generic.LinkedList<int> list)
    {
        if (list == null)
        {
            throw new ArgumentNullException();
        }
        var list2 = new System.Collections.Generic.LinkedList<int>();

        foreach (var item in list)
        {
            if (!list2.Contains(item))
            {
                list2.AddLast(item);
            }
            else { 
                continue;        
            }
        }

        return list2;
    }
}