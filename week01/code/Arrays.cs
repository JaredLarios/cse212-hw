public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // 1) create a List<double>
        // 2) make a For loop with the limit of the length
        // 3) inside For loop add in the list the amount of numbers multiply by number
        // 4) return the list converting it to Array

        List<double> multiplesList = new List<double>();
        for (int i = 1; i < length + 1; i++) multiplesList.Add(i * number);

        Console.Write(multiplesList);

        return multiplesList.ToArray();
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // 1) Calculate the starting index for the last 'amount' elements in the list.
        // 2) Create a new list containing these last 'amount' elements.
        // 3) Remove these elements from the end of the original list.
        // 4) Insert the removed elements at the beginning of the original list.

        int index = data.Count - amount;
        List<int> reverseList = new List<int>(data.GetRange(index, amount));

        data.RemoveRange(index, amount);

        data.InsertRange(0, reverseList);
    }
}
