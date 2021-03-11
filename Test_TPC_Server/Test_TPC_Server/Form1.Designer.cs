
namespace Test_TPC_Server
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.botonStartServer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.consola_texto = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.conectar_serie = new System.Windows.Forms.Button();
            this.baudRate = new System.Windows.Forms.TextBox();
            this.consolaSerie = new System.Windows.Forms.RichTextBox();
            this.consolaSerieLectura = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // botonStartServer
            // 
            this.botonStartServer.Location = new System.Drawing.Point(12, 12);
            this.botonStartServer.Name = "botonStartServer";
            this.botonStartServer.Size = new System.Drawing.Size(75, 23);
            this.botonStartServer.TabIndex = 0;
            this.botonStartServer.Text = "Start Server";
            this.botonStartServer.UseVisualStyleBackColor = true;
            this.botonStartServer.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // consola_texto
            // 
            this.consola_texto.Location = new System.Drawing.Point(12, 196);
            this.consola_texto.Name = "consola_texto";
            this.consola_texto.Size = new System.Drawing.Size(417, 242);
            this.consola_texto.TabIndex = 1;
            this.consola_texto.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(477, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // conectar_serie
            // 
            this.conectar_serie.Location = new System.Drawing.Point(477, 12);
            this.conectar_serie.Name = "conectar_serie";
            this.conectar_serie.Size = new System.Drawing.Size(161, 23);
            this.conectar_serie.TabIndex = 3;
            this.conectar_serie.Text = "Conectar Serie";
            this.conectar_serie.UseVisualStyleBackColor = true;
            this.conectar_serie.Click += new System.EventHandler(this.conectar_serie_Click);
            // 
            // baudRate
            // 
            this.baudRate.Location = new System.Drawing.Point(477, 74);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(299, 20);
            this.baudRate.TabIndex = 4;
            this.baudRate.Text = "9600";
            // 
            // consolaSerie
            // 
            this.consolaSerie.Location = new System.Drawing.Point(452, 196);
            this.consolaSerie.Name = "consolaSerie";
            this.consolaSerie.Size = new System.Drawing.Size(417, 108);
            this.consolaSerie.TabIndex = 5;
            this.consolaSerie.Text = "";
            // 
            // consolaSerieLectura
            // 
            this.consolaSerieLectura.Location = new System.Drawing.Point(452, 310);
            this.consolaSerieLectura.Name = "consolaSerieLectura";
            this.consolaSerieLectura.Size = new System.Drawing.Size(417, 128);
            this.consolaSerieLectura.TabIndex = 6;
            this.consolaSerieLectura.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.consolaSerieLectura);
            this.Controls.Add(this.consolaSerie);
            this.Controls.Add(this.baudRate);
            this.Controls.Add(this.conectar_serie);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.consola_texto);
            this.Controls.Add(this.botonStartServer);
            this.Name = "Form1";
            this.Text = "Servidor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonStartServer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox consola_texto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button conectar_serie;
        private System.Windows.Forms.TextBox baudRate;
        private System.Windows.Forms.RichTextBox consolaSerie;
        private System.Windows.Forms.RichTextBox consolaSerieLectura;
    }
}

