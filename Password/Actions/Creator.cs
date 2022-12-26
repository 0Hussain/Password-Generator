
using Password;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;

internal class MainGenerator
{
	public string GenerateFinalPass(byte passwordLength, byte level)
	{
		MyRandom rm = new();
		string finalPass = string.Empty;

		string[] stringSource =
		{
			"QWERTYUIOPASDFGHJKLZXCVBNM",
			"qwertyuiopasdfghjklzxcvbnm",
			@"!@#$%^&*~\/",
			"1234567890"
		};

		string str = level switch
		{
			1 => stringSource[1] + stringSource[3],
			2 => stringSource[0] + stringSource[1] + stringSource[2] + stringSource[3],
			_ =>"x"
		};

		_Recreat:
		finalPass = rm.CreatRandomPass(str, passwordLength);

		//Medium:at least 2 lowercase alphabet
		//Hard:at least 2 special character
		switch (level)
		{
			case 1:
				if (!IsStandard(finalPass, stringSource[3]))
				{
					goto _Recreat;
				}
				break;
			case 2:
				if (!IsStandard(finalPass, stringSource[2]))
				{
					goto _Recreat;
				}
				break;
		}

		return finalPass;

	}
	public bool IsStandard(string Pass, string characters)
	{
		char[] chars = characters.ToCharArray();
		byte counter = 0;
		foreach (char item in chars)
		{
			if (Pass.Contains(item))
			{
				counter++;
			}
		}
		return counter >= 2 ? true : false;
	}
}

