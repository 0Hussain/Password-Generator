namespace Password
{
	public partial class Form1 : Form
	{
		const string chars = "!@#$%^&*qwertyuiopasdfghjklzxcvbnm1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
		char[] Creator = chars.ToCharArray();
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void btnEnterLength_Click(object sender, EventArgs e)
		{
			txtResult.Text = Password();

		}

		public string Password()
		{
			string Result = string.Empty;
			Random rn = new();
			for(int i = 0; i < numericUpDownLength.Value; i++)
			{
				Result +=Creator[rn.Next(0,chars.Length)];
			}
			return Result;
		}
	}
}