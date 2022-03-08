namespace WinFormsApp1
{
    partial class TelaInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonUrnaCorreta = new System.Windows.Forms.Button();
            this.buttonUrnaFalsa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(532, 278);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonUrnaCorreta
            // 
            this.buttonUrnaCorreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUrnaCorreta.Location = new System.Drawing.Point(64, 308);
            this.buttonUrnaCorreta.Name = "buttonUrnaCorreta";
            this.buttonUrnaCorreta.Size = new System.Drawing.Size(143, 69);
            this.buttonUrnaCorreta.TabIndex = 1;
            this.buttonUrnaCorreta.Text = "URNA CORRETA";
            this.buttonUrnaCorreta.UseVisualStyleBackColor = true;
            this.buttonUrnaCorreta.Click += new System.EventHandler(this.buttonUrnaCorreta_Click);
            // 
            // buttonUrnaFalsa
            // 
            this.buttonUrnaFalsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUrnaFalsa.Location = new System.Drawing.Point(399, 308);
            this.buttonUrnaFalsa.Name = "buttonUrnaFalsa";
            this.buttonUrnaFalsa.Size = new System.Drawing.Size(143, 69);
            this.buttonUrnaFalsa.TabIndex = 2;
            this.buttonUrnaFalsa.Text = "URNA FALSA";
            this.buttonUrnaFalsa.UseVisualStyleBackColor = true;
            this.buttonUrnaFalsa.Click += new System.EventHandler(this.buttonUrnaFalsa_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 400);
            this.Controls.Add(this.buttonUrnaFalsa);
            this.Controls.Add(this.buttonUrnaCorreta);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TelaInicial";
            this.Text = "Tela Inicial";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonUrnaCorreta;
        private Button buttonUrnaFalsa;
    }
}