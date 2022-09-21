namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.GroupBox Pokedex;
            this.btncadastrar = new System.Windows.Forms.Button();
            this.dtpcap = new System.Windows.Forms.DateTimePicker();
            this.cbpokebola = new System.Windows.Forms.ComboBox();
            this.txtatck = new System.Windows.Forms.TextBox();
            this.txthp = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            Pokedex = new System.Windows.Forms.GroupBox();
            Pokedex.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pokedex
            // 
            Pokedex.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pokedex;
            Pokedex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Pokedex.Controls.Add(this.btncadastrar);
            Pokedex.Controls.Add(this.dtpcap);
            Pokedex.Controls.Add(this.cbpokebola);
            Pokedex.Controls.Add(this.txtatck);
            Pokedex.Controls.Add(this.txthp);
            Pokedex.Controls.Add(this.txtNome);
            Pokedex.Controls.Add(this.label5);
            Pokedex.Controls.Add(this.label4);
            Pokedex.Controls.Add(this.label3);
            Pokedex.Controls.Add(this.label2);
            Pokedex.Controls.Add(this.label1);
            Pokedex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Pokedex.ForeColor = System.Drawing.Color.DarkRed;
            Pokedex.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            Pokedex.Location = new System.Drawing.Point(37, 23);
            Pokedex.Name = "Pokedex";
            Pokedex.Size = new System.Drawing.Size(356, 451);
            Pokedex.TabIndex = 0;
            Pokedex.TabStop = false;
            Pokedex.Text = "Pokedex";
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btncadastrar.ForeColor = System.Drawing.Color.Black;
            this.btncadastrar.Location = new System.Drawing.Point(60, 372);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(123, 55);
            this.btncadastrar.TabIndex = 11;
            this.btncadastrar.Text = "CADASTRAR";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.Btncadastrar_Click);
            // 
            // dtpcap
            // 
            this.dtpcap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpcap.Location = new System.Drawing.Point(45, 240);
            this.dtpcap.Name = "dtpcap";
            this.dtpcap.Size = new System.Drawing.Size(85, 20);
            this.dtpcap.TabIndex = 10;
            // 
            // cbpokebola
            // 
            this.cbpokebola.FormattingEnabled = true;
            this.cbpokebola.Items.AddRange(new object[] {
            "Pokeball",
            "Greatball",
            "Ultraball",
            "MasterBall"});
            this.cbpokebola.Location = new System.Drawing.Point(136, 239);
            this.cbpokebola.Name = "cbpokebola";
            this.cbpokebola.Size = new System.Drawing.Size(105, 21);
            this.cbpokebola.TabIndex = 9;
            // 
            // txtatck
            // 
            this.txtatck.Location = new System.Drawing.Point(146, 191);
            this.txtatck.Name = "txtatck";
            this.txtatck.Size = new System.Drawing.Size(72, 20);
            this.txtatck.TabIndex = 6;
            // 
            // txthp
            // 
            this.txthp.Location = new System.Drawing.Point(48, 191);
            this.txthp.Name = "txthp";
            this.txthp.Size = new System.Drawing.Size(45, 20);
            this.txthp.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(47, 152);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(171, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(143, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pokebola utilizada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(45, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de Captura:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(159, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ataque:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(45, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hp(Vida):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(57, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Pokemon:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.WhatsApp_Image_2022_09_20_at_14_53_23;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1441, 652);
            this.Controls.Add(Pokedex);
            this.Name = "Form1";
            this.Text = "Form1";
            Pokedex.ResumeLayout(false);
            Pokedex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtatck;
        private System.Windows.Forms.TextBox txthp;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbpokebola;
        private System.Windows.Forms.DateTimePicker dtpcap;
        private System.Windows.Forms.Button btncadastrar;
    }
}

