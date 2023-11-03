using System.Globalization;

public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        // make new array to append to
            var newArray = new int[select.Length];
        // loop through selector array 1 by one
        // create inded to step through
            var index1 = 0;
            var index2 = 0;
            var index3 = 0;
            foreach(int num in select){
                if(num == 1){
                    newArray[index3] = list1[index1];
                    index1 += 1;
                }else{
                    newArray[index3] = list2[index2];
                    index2 += 1;
                }
                index3 += 1;
            }
        return newArray;
    }
    
}