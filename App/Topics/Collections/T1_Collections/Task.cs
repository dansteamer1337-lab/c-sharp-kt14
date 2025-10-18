using System.Collections;

namespace App.Topics.Collections.T1_Collections;

public static class CollectionsTasks
{
    public static System.Collections.ArrayList
        FilterUniqueStringsNonGeneric(System.Collections.IEnumerable source)
    {
        var array = new System.Collections.ArrayList();
        var array2 = new System.Collections.ArrayList();

        foreach (var item in source)
        {
            if (item is string str)
            {
                string asd = str.Trim();
                if (!array2.Contains(asd.ToLower()))
                {
                    array.Add(asd);
                }
                array2.Add(asd.ToLower());
            }
        }
        return array;
    }
    public static System.Collections.Generic.List<string> 
        FilterUniqueStringsGeneric(System.Collections.Generic.IEnumerable<string> source)
    {
        var array = new List<string>();
        var array2 = new List<string>();

        foreach (var item in source)
        {
            if (item is string str && item != "" && item != " ")
            {
                string asd = str.Trim();
                if (!array2.Contains(asd.ToLower()) && asd != "")
                {
                    array.Add(asd);
                }
                array2.Add(asd.ToLower());
            }
        }
        return array;
    }
}