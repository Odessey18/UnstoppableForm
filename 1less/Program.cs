using System;
using System.Windows.Forms;
using System.Drawing.Design;
using System.Drawing;


class MainForm : Form
{
	Button Right;
	Button Left;
	Button Up;
	Button Down;
	int countClick = 0;


	public MainForm()
	{
		


		Button Right = new Button();
		Button Left = new Button();
		Button Up = new Button();
		Button Down = new Button();
		Down.Text = "Down";
		Left.Text = "Left";
		Up.Text = "Up";
		Right.Text = "Right";

		Controls.Add(Down);
		Controls.Add(Left);
		Controls.Add(Right);
		Controls.Add(Up);
		Up.Location = new Point(100, 50);
		Right.Location = new Point(150, 100);
		Left.Location = new Point(50, 100);
		Down.Location = new Point(100, 150);

		Down.Click += Down_Click;
		Left.Click += Left_Click;
		Right.Click += Right_Click;
		Up.Click += Up_Click;

	}

	void Up_Click (object sender, EventArgs e)
	{
		this.Location = new Point(this.Location.X, this.Location.Y - 10);
	
	}

	void Right_Click (object sender, EventArgs e)
	{
		this.Location = new Point(this.Location.X + 10, this.Location.Y);
	}

	void Left_Click (object sender, EventArgs e)
	{
		this.Location = new Point(this.Location.X - 10, this.Location.Y);
	}

	void Down_Click (object sender, EventArgs e)
	{
		this.Location = new Point(this.Location.X, this.Location.Y + 10);
	}

	
}

class MainClass
{
	[STAThread]
		public static void Main (string[] args)
		{
		Application.EnableVisualStyles();
		Application.Run( new MainForm());
		}
}




