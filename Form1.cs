using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Bingo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label B;
		private System.Windows.Forms.Label I;
		private System.Windows.Forms.Label N;
		private System.Windows.Forms.Label G;
		private System.Windows.Forms.Label O;
		private System.Windows.Forms.Label Num;
		private System.Windows.Forms.Button Next;
		private System.Windows.Forms.Button Reset;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.B = new System.Windows.Forms.Label();
            this.I = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.Label();
            this.G = new System.Windows.Forms.Label();
            this.O = new System.Windows.Forms.Label();
            this.Num = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B
            // 
            this.B.ForeColor = System.Drawing.Color.Lime;
            this.B.Location = new System.Drawing.Point(16, 72);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(272, 32);
            this.B.TabIndex = 0;
            this.B.Text = "B";
            // 
            // I
            // 
            this.I.ForeColor = System.Drawing.Color.Lime;
            this.I.Location = new System.Drawing.Point(16, 112);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(272, 32);
            this.I.TabIndex = 1;
            this.I.Text = "I";
            // 
            // N
            // 
            this.N.ForeColor = System.Drawing.Color.Lime;
            this.N.Location = new System.Drawing.Point(16, 152);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(272, 32);
            this.N.TabIndex = 2;
            this.N.Text = "N";
            // 
            // G
            // 
            this.G.ForeColor = System.Drawing.Color.Lime;
            this.G.Location = new System.Drawing.Point(16, 192);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(272, 32);
            this.G.TabIndex = 3;
            this.G.Text = "G";
            // 
            // O
            // 
            this.O.ForeColor = System.Drawing.Color.Lime;
            this.O.Location = new System.Drawing.Point(16, 232);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(272, 32);
            this.O.TabIndex = 4;
            this.O.Text = "O";
            // 
            // Num
            // 
            this.Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num.Location = new System.Drawing.Point(144, 8);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(128, 56);
            this.Num.TabIndex = 5;
            // 
            // Next
            // 
            this.Next.ForeColor = System.Drawing.Color.Red;
            this.Next.Location = new System.Drawing.Point(32, 8);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 6;
            this.Next.Text = "Next";
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Reset
            // 
            this.Reset.ForeColor = System.Drawing.Color.Red;
            this.Reset.Location = new System.Drawing.Point(32, 40);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(56, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 48);
            this.label1.TabIndex = 8;
            this.label1.Text = "Created by Tony Brix\n       UziTech.com";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(292, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.O);
            this.Controls.Add(this.G);
            this.Controls.Add(this.N);
            this.Controls.Add(this.I);
            this.Controls.Add(this.B);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "B I N G O";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
		int [] array = new int[75];
		bool [] array2 = new bool[75];
		int num = 75;
		private void Next_Click(object sender, System.EventArgs e)
		{
			if (num != 0)
				next();
			else
			{
				if (System.Windows.Forms.MessageBox.Show("All Numbers Have Been Called\n\nReset Numbers?","Reset Numbers?",System.Windows.Forms.MessageBoxButtons.YesNo,System.Windows.Forms.MessageBoxIcon.Exclamation,System.Windows.Forms.MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
					reset();
			}
		}

		private void next()
		{
			int rand;
			int rand1;
			rand = new Random().Next();
			rand1 = rand % num;
			rand = array[rand1];
			if ((rand - 1) / 15 == 0)
				Num.Text = "B";
			else if ((rand - 1) / 15 == 1)
				Num.Text = "I";
			else if ((rand - 1) / 15 == 2)
				Num.Text = "N";
			else if ((rand - 1) / 15 == 3)
				Num.Text = "G";
			else if ((rand - 1) / 15 == 4)
				Num.Text = "O";
			Num.Text = Num.Text + " " + rand;
			for (int i=rand1;i<74;i++)
			{
				array[i] = array[i + 1];
			}
			array[74] = 0;
			array2[rand - 1] = true;
			num--;
			B.Text = "B  ";
			I.Text = "I  ";
			N.Text = "N";
			G.Text = "G";
			O.Text = "O";
			for (int temp = 1; temp < 76; temp++)
			{
				if (array2[temp - 1] && temp < 16)
				{
					B.Text = B.Text + " " + temp;
					if (temp < 10)
						B.Text = B.Text + " ";
					if (temp < 9)
						B.Text = B.Text + " ";
				}
				else if (array2[temp - 1] && temp < 31)
					I.Text = I.Text + " " + temp;
				else if (array2[temp - 1] && temp < 46)
					N.Text = N.Text + " " + temp;
				else if (array2[temp - 1] && temp < 61)
					G.Text = G.Text + " " + temp;
				else if (array2[temp - 1] && temp < 76)
					O.Text = O.Text + " " + temp;
			}

   		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			reset();
		}

		private void Reset_Click(object sender, System.EventArgs e)
		{
			reset();
		}
		private void reset()
		{
			Num.Text = "";
			B.Text = "B";
			I.Text = "I";
			N.Text = "N";
			G.Text = "G";
			O.Text = "O";
			for (int temp = 0; temp < 75; temp++)
				array[temp] = temp + 1;
			num = 75;
			for (int i = 0; i < 75; i++)
				array2[i] = false;
		}
	}
}
