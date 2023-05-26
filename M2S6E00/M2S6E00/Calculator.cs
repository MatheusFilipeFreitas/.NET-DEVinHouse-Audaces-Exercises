using System;

public class Calculator
{
    public int Sum(List<int> numbers)
    {
        int returnValue = 0;
        numbers.ForEach(numbers => returnValue + numbers);
        return returnValue;
    }

    public List<int> ReverseOrder(List<int> numbers)
    {
        List<int> returnValue = new List<int>();
        for(int i = 0; i < numbers.Count; i++)
        {
            returnValue.Add(numbers[numbers.Count - 1 - i]);
        }
        return returnValue;
    }

    public List<int> Order(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            for (int j = 0; j < numbers.Count - i - 1; j++)
            {
                if (numbers[j] <= numbers[j + 1]) continue;
                (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
            }

        }
        return numbers;
    }
}
