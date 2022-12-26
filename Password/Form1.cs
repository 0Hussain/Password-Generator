namespace Password
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnEnterLength_Click(object sender, EventArgs e)
		{
			lblCopy.Text = "";
			MainGenerator cr = new();
			//Password level =>medium:1,hard=>2
			byte level =(byte)(rdbtnMedium.Checked == true ? 1 : 2);

			byte passLength = (byte)numericUpDownLength.Value;
			txtResult.Text = cr.GenerateFinalPass(passLength,level);
		}

		private void btnCopy_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(txtResult.Text);
			lblCopy.Text = "Copied!";
		}
	}
}