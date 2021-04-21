
namespace RezervariHotel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbCamera = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.btAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btAfisare = new System.Windows.Forms.Button();
            this.cbPlata = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(209, 42);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(125, 26);
            this.tbNume.TabIndex = 1;
            // 
            // tbCamera
            // 
            this.tbCamera.Location = new System.Drawing.Point(209, 89);
            this.tbCamera.Name = "tbCamera";
            this.tbCamera.Size = new System.Drawing.Size(125, 26);
            this.tbCamera.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Camera";
            // 
            // dpCheckIn
            // 
            this.dpCheckIn.Location = new System.Drawing.Point(209, 138);
            this.dpCheckIn.Name = "dpCheckIn";
            this.dpCheckIn.Size = new System.Drawing.Size(270, 26);
            this.dpCheckIn.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Check-In";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Check-Out";
            // 
            // dpCheckOut
            // 
            this.dpCheckOut.Location = new System.Drawing.Point(209, 181);
            this.dpCheckOut.Name = "dpCheckOut";
            this.dpCheckOut.Size = new System.Drawing.Size(270, 26);
            this.dpCheckOut.TabIndex = 6;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(53, 282);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(125, 33);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Inregistrare";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btAfisare
            // 
            this.btAfisare.Location = new System.Drawing.Point(265, 282);
            this.btAfisare.Name = "btAfisare";
            this.btAfisare.Size = new System.Drawing.Size(154, 33);
            this.btAfisare.TabIndex = 9;
            this.btAfisare.Text = "Afisare inregistrari";
            this.btAfisare.UseVisualStyleBackColor = true;
            this.btAfisare.Click += new System.EventHandler(this.btAfisare_Click);
            // 
            // cbPlata
            // 
            this.cbPlata.FormattingEnabled = true;
            this.cbPlata.Items.AddRange(new object[] {
            "nu",
            "da"});
            this.cbPlata.Location = new System.Drawing.Point(209, 228);
            this.cbPlata.Name = "cbPlata";
            this.cbPlata.Size = new System.Drawing.Size(74, 28);
            this.cbPlata.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "S-a efectuat plata?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbPlata);
            this.Controls.Add(this.btAfisare);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dpCheckOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dpCheckIn);
            this.Controls.Add(this.tbCamera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbCamera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpCheckIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dpCheckOut;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btAfisare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPlata;
    }
}

