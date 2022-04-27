
namespace ProjetoCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SomaButton = new System.Windows.Forms.Button();
            this.SubtButton = new System.Windows.Forms.Button();
            this.MultiButton = new System.Windows.Forms.Button();
            this.DiviButton = new System.Windows.Forms.Button();
            this.RadButton = new System.Windows.Forms.Button();
            this.PoteButton = new System.Windows.Forms.Button();
            this.SegundoNumText = new System.Windows.Forms.Label();
            this.SegundaTextBox = new System.Windows.Forms.TextBox();
            this.FirstNumText = new System.Windows.Forms.Label();
            this.PrimeiraTextBox = new System.Windows.Forms.TextBox();
            this.ResultadoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SomaButton
            // 
            this.SomaButton.BackColor = System.Drawing.Color.Brown;
            this.SomaButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SomaButton.BackgroundImage")));
            this.SomaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SomaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SomaButton.Location = new System.Drawing.Point(29, 357);
            this.SomaButton.Name = "SomaButton";
            this.SomaButton.Size = new System.Drawing.Size(120, 71);
            this.SomaButton.TabIndex = 0;
            this.SomaButton.UseVisualStyleBackColor = false;
            this.SomaButton.Click += new System.EventHandler(this.SomaButton_Click);
            // 
            // SubtButton
            // 
            this.SubtButton.BackColor = System.Drawing.Color.Brown;
            this.SubtButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SubtButton.BackgroundImage")));
            this.SubtButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SubtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubtButton.Location = new System.Drawing.Point(155, 357);
            this.SubtButton.Name = "SubtButton";
            this.SubtButton.Size = new System.Drawing.Size(120, 71);
            this.SubtButton.TabIndex = 1;
            this.SubtButton.UseVisualStyleBackColor = false;
            this.SubtButton.Click += new System.EventHandler(this.SubtButton_Click);
            // 
            // MultiButton
            // 
            this.MultiButton.BackColor = System.Drawing.Color.Brown;
            this.MultiButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MultiButton.BackgroundImage")));
            this.MultiButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MultiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MultiButton.Location = new System.Drawing.Point(281, 357);
            this.MultiButton.Name = "MultiButton";
            this.MultiButton.Size = new System.Drawing.Size(120, 71);
            this.MultiButton.TabIndex = 2;
            this.MultiButton.UseVisualStyleBackColor = false;
            this.MultiButton.Click += new System.EventHandler(this.MultiButton_Click);
            // 
            // DiviButton
            // 
            this.DiviButton.BackColor = System.Drawing.Color.Brown;
            this.DiviButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DiviButton.BackgroundImage")));
            this.DiviButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DiviButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiviButton.Location = new System.Drawing.Point(407, 357);
            this.DiviButton.Name = "DiviButton";
            this.DiviButton.Size = new System.Drawing.Size(120, 71);
            this.DiviButton.TabIndex = 3;
            this.DiviButton.UseVisualStyleBackColor = false;
            this.DiviButton.Click += new System.EventHandler(this.DiviButton_Click);
            // 
            // RadButton
            // 
            this.RadButton.BackColor = System.Drawing.Color.Brown;
            this.RadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RadButton.BackgroundImage")));
            this.RadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadButton.Location = new System.Drawing.Point(533, 357);
            this.RadButton.Name = "RadButton";
            this.RadButton.Size = new System.Drawing.Size(120, 71);
            this.RadButton.TabIndex = 4;
            this.RadButton.UseVisualStyleBackColor = false;
            this.RadButton.Click += new System.EventHandler(this.RadButton_Click);
            // 
            // PoteButton
            // 
            this.PoteButton.BackColor = System.Drawing.Color.Brown;
            this.PoteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PoteButton.BackgroundImage")));
            this.PoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PoteButton.Location = new System.Drawing.Point(659, 357);
            this.PoteButton.Name = "PoteButton";
            this.PoteButton.Size = new System.Drawing.Size(120, 71);
            this.PoteButton.TabIndex = 5;
            this.PoteButton.UseVisualStyleBackColor = false;
            this.PoteButton.Click += new System.EventHandler(this.PoteButton_Click);
            // 
            // SegundoNumText
            // 
            this.SegundoNumText.AutoSize = true;
            this.SegundoNumText.BackColor = System.Drawing.Color.DarkGray;
            this.SegundoNumText.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SegundoNumText.ForeColor = System.Drawing.Color.Brown;
            this.SegundoNumText.Location = new System.Drawing.Point(34, 188);
            this.SegundoNumText.Name = "SegundoNumText";
            this.SegundoNumText.Size = new System.Drawing.Size(359, 44);
            this.SegundoNumText.TabIndex = 8;
            this.SegundoNumText.Text = "Segundo Número";
            this.SegundoNumText.Click += new System.EventHandler(this.SegundoNumText_Click);
            // 
            // SegundaTextBox
            // 
            this.SegundaTextBox.Location = new System.Drawing.Point(29, 235);
            this.SegundaTextBox.Name = "SegundaTextBox";
            this.SegundaTextBox.Size = new System.Drawing.Size(664, 20);
            this.SegundaTextBox.TabIndex = 9;
            this.SegundaTextBox.TextChanged += new System.EventHandler(this.SegundaTextBox_TextChanged);
            // 
            // FirstNumText
            // 
            this.FirstNumText.AutoSize = true;
            this.FirstNumText.BackColor = System.Drawing.Color.DarkGray;
            this.FirstNumText.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNumText.ForeColor = System.Drawing.Color.Brown;
            this.FirstNumText.Location = new System.Drawing.Point(34, 37);
            this.FirstNumText.Name = "FirstNumText";
            this.FirstNumText.Size = new System.Drawing.Size(367, 44);
            this.FirstNumText.TabIndex = 10;
            this.FirstNumText.Text = "Primeiro Número";
            this.FirstNumText.Click += new System.EventHandler(this.FirstNumText_Click);
            // 
            // PrimeiraTextBox
            // 
            this.PrimeiraTextBox.Location = new System.Drawing.Point(29, 84);
            this.PrimeiraTextBox.Name = "PrimeiraTextBox";
            this.PrimeiraTextBox.Size = new System.Drawing.Size(664, 20);
            this.PrimeiraTextBox.TabIndex = 12;
            this.PrimeiraTextBox.TextChanged += new System.EventHandler(this.PrimeiraTextBox_TextChanged);
            // 
            // ResultadoLabel
            // 
            this.ResultadoLabel.AutoSize = true;
            this.ResultadoLabel.BackColor = System.Drawing.Color.DarkGray;
            this.ResultadoLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoLabel.ForeColor = System.Drawing.Color.Brown;
            this.ResultadoLabel.Location = new System.Drawing.Point(34, 293);
            this.ResultadoLabel.Name = "ResultadoLabel";
            this.ResultadoLabel.Size = new System.Drawing.Size(0, 44);
            this.ResultadoLabel.TabIndex = 13;
            this.ResultadoLabel.Click += new System.EventHandler(this.ResultadoLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultadoLabel);
            this.Controls.Add(this.PrimeiraTextBox);
            this.Controls.Add(this.FirstNumText);
            this.Controls.Add(this.SegundaTextBox);
            this.Controls.Add(this.SegundoNumText);
            this.Controls.Add(this.PoteButton);
            this.Controls.Add(this.RadButton);
            this.Controls.Add(this.DiviButton);
            this.Controls.Add(this.MultiButton);
            this.Controls.Add(this.SubtButton);
            this.Controls.Add(this.SomaButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SomaButton;
        private System.Windows.Forms.Button SubtButton;
        private System.Windows.Forms.Button MultiButton;
        private System.Windows.Forms.Button DiviButton;
        private System.Windows.Forms.Button RadButton;
        private System.Windows.Forms.Button PoteButton;
        private System.Windows.Forms.Label SegundoNumText;
        private System.Windows.Forms.TextBox SegundaTextBox;
        private System.Windows.Forms.Label FirstNumText;
        private System.Windows.Forms.TextBox PrimeiraTextBox;
        private System.Windows.Forms.Label ResultadoLabel;
    }
}

