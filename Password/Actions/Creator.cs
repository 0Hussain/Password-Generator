
using Password;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;

internal class Creator
{
	public string CreatFinallyPass(byte passwordLength)
	{
		MyRandom rm = new();
		string finallyPass = string.Empty;

		string[] stringSource =
		{
			"QWERTYUIOPASDFGHJKLZXCVBNM",
			"qwertyuiopasdfghjklzxcvbnm",
			@"!@#$%^&*~\/*",
			"1234567890"
		};
		string all = stringSource[0] + stringSource[1] + stringSource[2] + stringSource[3];
		_Recreat:
		finallyPass = rm.CreatRandomPass(all, passwordLength);

		if (!IsStandard(finallyPass, stringSource[2]))
		{
			goto _Recreat;
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

