
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        char delimiter = '\t';
        if (numbers.StartsWith("//"))
        {
            delimiter = numbers[2];
        }

        string[] nums = { };


        if (numbers != "")
            nums = numbers.Split(',','\n',delimiter,'/');
        if (nums.Length == 0)
            return 0;
        else
        {
            int sum = 0;
            int numberAsInt = 0;
            foreach(string number in nums)
            {
                if (number != "")
                {
                    numberAsInt = int.Parse(number);
                    sum += numberAsInt;
                }
            }
            return sum;
        }
       
    }
}
