namespace PoS
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            titulo = new Label();
            Desarrollado = new Label();
            HoraFecha = new Label();
            time = new System.Windows.Forms.Timer(components);
            dataGridProductos = new DataGridView();
            pictureBoxLogo = new PictureBox();
            txtCodigo = new TextBox();
            labeltotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            titulo.Location = new Point(194, 17);
            titulo.Name = "titulo";
            titulo.Size = new Size(283, 33);
            titulo.TabIndex = 0;
            titulo.Text = "ABARROTES RUBÉN";
            // 
            // Desarrollado
            // 
            Desarrollado.AutoSize = true;
            Desarrollado.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Desarrollado.Location = new Point(348, 68);
            Desarrollado.Name = "Desarrollado";
            Desarrollado.Size = new Size(292, 20);
            Desarrollado.TabIndex = 1;
            Desarrollado.Text = "Desarrollado por:  Rubén Bernardo Ruíz Vega";
            // 
            // HoraFecha
            // 
            HoraFecha.AutoSize = true;
            HoraFecha.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HoraFecha.Location = new Point(347, 111);
            HoraFecha.Name = "HoraFecha";
            HoraFecha.Size = new Size(89, 20);
            HoraFecha.TabIndex = 2;
            HoraFecha.Text = "Hora y Fecha";
            // 
            // time
            // 
            time.Enabled = true;
            time.Interval = 1000;
            time.Tick += time_Tick;
            // 
            // dataGridProductos
            // 
            dataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProductos.Location = new Point(253, 154);
            dataGridProductos.Margin = new Padding(3, 2, 3, 2);
            dataGridProductos.Name = "dataGridProductos";
            dataGridProductos.RowHeadersVisible = false;
            dataGridProductos.RowHeadersWidth = 51;
            dataGridProductos.RowTemplate.Height = 29;
            dataGridProductos.Size = new Size(262, 141);
            dataGridProductos.TabIndex = 3;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.logoMenu;
            pictureBoxLogo.Location = new Point(572, 100);
            pictureBoxLogo.Margin = new Padding(3, 2, 3, 2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(109, 46);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 4;
            pictureBoxLogo.TabStop = false;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Arial Narrow", 36F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.Location = new Point(139, 82);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(110, 63);
            txtCodigo.TabIndex = 5;
            txtCodigo.KeyPress += txtCodigo_KeyPress_1;
            txtCodigo.PreviewKeyDown += txtCodigo_PreviewKeyDown;
            // 
            // labeltotal
            // 
            labeltotal.AutoSize = true;
            labeltotal.Location = new Point(81, 40);
            labeltotal.Name = "labeltotal";
            labeltotal.Size = new Size(44, 15);
            labeltotal.TabIndex = 6;
            labeltotal.Text = "Total: $";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(labeltotal);
            Controls.Add(txtCodigo);
            Controls.Add(pictureBoxLogo);
            Controls.Add(dataGridProductos);
            Controls.Add(HoraFecha);
            Controls.Add(Desarrollado);
            Controls.Add(titulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Label Desarrollado;
        private Label HoraFecha;
        private System.Windows.Forms.Timer time;
        private DataGridView dataGridProductos;
        private PictureBox pictureBoxLogo;
        private TextBox txtCodigo;
        private Label labeltotal;
    }
}