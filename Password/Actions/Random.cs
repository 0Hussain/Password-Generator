

public class MyRandom
{
	public string CreatRandomPass(string stringSource,byte PassLength)
	{
		string Result = string.Empty;
		Random rn = new();
		char[] charsArray = stringSource.ToCharArray();
		for (int i = 0; i < PassLength; i++)
		{
			Result += charsArray[rn.Next(0, stringSource.Length)];
		}
		return Result;
	}
}
