using System;
 class ConvertToBinary
{
    //to store the binary value of Binary value of Number (1 sign bit , 7 bit integral value and 8bit fractional value)
	public int[] m_FloatBinary = new int[16]; 
	//stores the float value 								
	private double m_Number;
    /// <summary>
    /// Constructor to teke the inputs
    /// </summary>
    public ConvertToBinary()
    {
        Console.Write("enter float number(range -63.999 to 127.999):");
		m_Number = double.Parse(Console.ReadLine());
        Console.Write("Binary representation of the number : ");
        DisplayInputsAsBinary(ConvertFloatToBinary(m_Number));
    }
    /// <summary>
    /// used to Display the inputs that are converted to binary form
    /// </summary>
    /// <param name="floatBinary">Binary converted number</param>
	public void DisplayInputsAsBinary(int[] floatBinary)
	{
		for (int temp = 0; temp <= 15; temp++)
		{
			Console.Write(floatBinary[temp]);
			Console.Write((temp == 0 ) ? (" ") : (""));
			Console.Write((temp == 7 ) ? (".") : (""));
		}
		Console.WriteLine("\n");
	}
    /// <summary>
	/// Used to convert the float value to binary value by dividing into integer and fractiuonal parts
	/// </summary>
	/// <param name="number">the float number</param>
	/// <returns>the binary array</returns>
	public int[] ConvertFloatToBinary(double number)
	{
		int numberIntegerPart = (int)number,complement=1; 						 			
		//int[] floatBinary = new int[16];
		//checking the sign of float number and storing it into Float_Number[0]
		m_FloatBinary[0] = (number < 0) ? (1) : (0);							 	
		for(int temp=7;temp>0;temp--)					 			 
		{
			m_FloatBinary[temp] = (numberIntegerPart != 0) ? (numberIntegerPart % 2) : 0;
			numberIntegerPart = numberIntegerPart / 2;
		}
		float numberFractionalPart = (float)number - (int)number; 				 		
		for (int temp = 8; temp < 16; temp++)								 		
		{
			numberFractionalPart = numberFractionalPart * 2;
			m_FloatBinary[temp] = (int)numberFractionalPart;
			numberFractionalPart = numberFractionalPart - m_FloatBinary[temp];
		}
		if (m_FloatBinary[0] == 1)
		{
			for(int temp=15 ; temp>=1 ; temp--)
			{
				m_FloatBinary[temp] = (m_FloatBinary[temp] == 0) ? (1) : (0);
				int temp2 = m_FloatBinary[temp];											
				m_FloatBinary[temp] = m_FloatBinary[temp] ^ complement;
				complement = temp2 & complement;
			}
		}
		return m_FloatBinary;																			
	}
}
class BinaryAddition
{
    //to store the float value
	private double m_DoubleResult=0;
    //to store the 17 bit result
	public int[] m_Result = new int[17];
	
	/// <summary>
	/// By using Full adder concept of addition of binary bits we are adding the two binary arrays 
	/// this solves all the 4 conditions of (+,+),(+,-),(-,+) and (-,-) respectivly
	/// if Result[16]=1 we have to perform 2's complement
	/// if Result[16]=0 no need of 2's complement
	/// </summary>
	/// <param name="firstNumberBinary">Num1 as binary</param>
	/// <param name="secondNumberBinary">Num2 as binary</param>
	public int[] AddBinaryNumbers(int[] firstNumberBinary, int[] secondNumberBinary)
	{
		 										
		int carry = 0;
		int complement = 1;
		for (int temp3 = 15,temp4=0; temp3 >= 1; temp3--, temp4++)
		{	
			m_Result[temp4]= firstNumberBinary[temp3] ^ secondNumberBinary[temp3] ^carry;
			carry= (firstNumberBinary[temp3] | secondNumberBinary[temp3]) & (secondNumberBinary[temp3] | carry) & (carry |firstNumberBinary[temp3]);
		}
		if(firstNumberBinary[0] == 0 && secondNumberBinary[0] == 0)							
		{
			m_Result[15] = carry;
		}
		else if ((firstNumberBinary[0] == 1 && secondNumberBinary[0] == 1) || carry==0)			
		{
			m_Result[15] = 1;
			for (int temp1 = 0; temp1 <= 16; temp1++)
			{
				m_Result[temp1] = (m_Result[temp1] == 0) ? (1) : (0);
				int x = m_Result[temp1];
				m_Result[temp1] = m_Result[temp1] ^ complement;
				complement = x & complement;
			}
		}
		return m_Result;
	}
	/// <summary>
	/// Display the result 
	/// </summary>
	/// <param name="Result">has result in it</param>
	public void DisplayResult(int[] Result)
	{
		for (int temp4 = 16; temp4 >= 0; temp4--)									 		
		{
			Console.Write((temp4 == 7 ) ? (".") : (""));
			Console.Write(Result[temp4]);
			Console.Write((temp4 == 16) ? (" ") : (""));
		}
		return;
	}
	/// <summary>
	/// used to display the result in float number
	/// </summary>
	/// <param name="Result">Result</param>
	/// <returns></returns>
	public double ConvertBinaryToFloat(int[] Result)
	{
		for(int temp=7,temp1=1;temp>=0;temp--,temp1++)
		{
			m_DoubleResult=m_DoubleResult+(Result[temp]*Math.Pow(0.5,temp1));
		}
		for(int temp=8,temp1=0;temp<=15;temp++,temp1++)
		{
			m_DoubleResult=m_DoubleResult+(Result[temp]*Math.Pow(2,temp1));
		}
		if(Result[16]==1)
		{
			m_DoubleResult=(-1)*m_DoubleResult;
		}
		return m_DoubleResult;
	}

}