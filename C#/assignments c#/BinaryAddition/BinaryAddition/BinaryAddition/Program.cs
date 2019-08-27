using System;
public class program
{
    public static void Main()
    {
        Console.WriteLine("Enter to float numbers to convert it to binary and add them\n");
        //creation of objects to have acess to all methods and variables of class
        ConvertToBinary firstNumber = new ConvertToBinary();
        ConvertToBinary secondNumber = new ConvertToBinary();
        BinaryAddition additionResult = new BinaryAddition();
        Console.Write("\nResult in Binary : ");
        //add the number and Displays the result
        additionResult.DisplayResult(additionResult.AddBinaryNumbers(firstNumber.m_FloatBinary, secondNumber.m_FloatBinary));
        Console.Write("\nResult in Float : " + additionResult.ConvertBinaryToFloat(additionResult.m_Result));
        Console.ReadLine();
    }
}