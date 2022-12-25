
using Password;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;

internal class Creator
{
	public string CreatFinallyPass(byte passwordLength, byte level)
	{
		MyRandom rm = new();
		string finallyPass = string.Empty;

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
		finallyPass = rm.CreatRandomPass(str, passwordLength);

		//Medium:at least 2 lowercase alphabet
		//Hard:at least 2 special character
		switch (level)
		{
			case 1:
				if (!IsStandard(finallyPass, stringSource[3]))
				{
					goto _Recreat;
				}
				break;
			case 2:
				if (!IsStandard(finallyPass, stringSource[2]))
				{
					goto _Recreat;
				}
				break;
		}

		return finallyPass;

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

