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
			Creator cr = new();
			byte passLength = (byte)numericUpDownLength.Value;
			txtResult.Text = cr.CreatFinallyPass(passLength);
		}
	}
}