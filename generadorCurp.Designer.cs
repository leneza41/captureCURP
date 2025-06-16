namespace captureCURP
{
    partial class generadorCurp
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtApellidoMaterno = new TextBox();
            txtApellidoPaterno = new TextBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblSexo = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            lblFecha = new Label();
            panel3 = new Panel();
            lblEntidadFederativa = new Label();
            panel4 = new Panel();
            cboSexo = new ComboBox();
            cboEntidadFederativa = new ComboBox();
            btnGenerar = new Button();
            lblCurp = new Label();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtApellidoMaterno);
            panel1.Controls.Add(txtApellidoPaterno);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(lblNombre);
            panel1.Location = new Point(11, 12);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 256);
            panel1.TabIndex = 0;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Font = new Font("Segoe UI", 18F);
            txtApellidoMaterno.Location = new Point(3, 175);
            txtApellidoMaterno.Margin = new Padding(3, 4, 3, 4);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.PlaceholderText = "Apellido Materno";
            txtApellidoMaterno.Size = new Size(363, 47);
            txtApellidoMaterno.TabIndex = 6;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Font = new Font("Segoe UI", 18F);
            txtApellidoPaterno.Location = new Point(3, 116);
            txtApellidoPaterno.Margin = new Padding(3, 4, 3, 4);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.PlaceholderText = "Apellido Paterno";
            txtApellidoPaterno.Size = new Size(363, 47);
            txtApellidoPaterno.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 18F);
            txtNombre.Location = new Point(3, 59);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(363, 47);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 18F);
            lblNombre.Location = new Point(3, 11);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(278, 41);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre y apellidos";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Segoe UI", 18F);
            lblSexo.Location = new Point(82, 138);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(82, 41);
            lblSexo.TabIndex = 7;
            lblSexo.Text = "Sexo";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Font = new Font("Segoe UI", 18F);
            dtpFechaNacimiento.Location = new Point(3, 65);
            dtpFechaNacimiento.Margin = new Padding(3, 4, 3, 4);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(530, 47);
            dtpFechaNacimiento.TabIndex = 2;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 18F);
            lblFecha.Location = new Point(0, 5);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(297, 41);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "Fecha de Nacimiento";
            // 
            // panel3
            // 
            panel3.Controls.Add(dtpFechaNacimiento);
            panel3.Controls.Add(lblFecha);
            panel3.Location = new Point(15, 299);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(537, 129);
            panel3.TabIndex = 9;
            // 
            // lblEntidadFederativa
            // 
            lblEntidadFederativa.AutoSize = true;
            lblEntidadFederativa.Font = new Font("Segoe UI", 18F);
            lblEntidadFederativa.Location = new Point(82, 7);
            lblEntidadFederativa.Name = "lblEntidadFederativa";
            lblEntidadFederativa.Size = new Size(262, 41);
            lblEntidadFederativa.TabIndex = 8;
            lblEntidadFederativa.Text = "Entidad Federativa";
            // 
            // panel4
            // 
            panel4.Controls.Add(cboSexo);
            panel4.Controls.Add(lblSexo);
            panel4.Controls.Add(cboEntidadFederativa);
            panel4.Controls.Add(lblEntidadFederativa);
            panel4.Location = new Point(411, 12);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(406, 256);
            panel4.TabIndex = 10;
            // 
            // cboSexo
            // 
            cboSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSexo.Font = new Font("Segoe UI", 18F);
            cboSexo.FormattingEnabled = true;
            cboSexo.Location = new Point(82, 185);
            cboSexo.Margin = new Padding(3, 4, 3, 4);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(265, 49);
            cboSexo.TabIndex = 10;
            // 
            // cboEntidadFederativa
            // 
            cboEntidadFederativa.DropDownHeight = 200;
            cboEntidadFederativa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEntidadFederativa.Font = new Font("Segoe UI", 18F);
            cboEntidadFederativa.FormattingEnabled = true;
            cboEntidadFederativa.IntegralHeight = false;
            cboEntidadFederativa.Location = new Point(82, 59);
            cboEntidadFederativa.Margin = new Padding(3, 4, 3, 4);
            cboEntidadFederativa.Name = "cboEntidadFederativa";
            cboEntidadFederativa.Size = new Size(265, 49);
            cboEntidadFederativa.Sorted = true;
            cboEntidadFederativa.TabIndex = 9;
            // 
            // btnGenerar
            // 
            btnGenerar.Font = new Font("Segoe UI", 18F);
            btnGenerar.Location = new Point(16, 59);
            btnGenerar.Margin = new Padding(3, 4, 3, 4);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(221, 53);
            btnGenerar.TabIndex = 11;
            btnGenerar.Text = "Generar CURP";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lblCurp
            // 
            lblCurp.AutoSize = true;
            lblCurp.Font = new Font("Segoe UI", 18F);
            lblCurp.Location = new Point(18, 443);
            lblCurp.Name = "lblCurp";
            lblCurp.Size = new Size(93, 41);
            lblCurp.TabIndex = 12;
            lblCurp.Text = "CURP";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnGenerar);
            panel5.Location = new Point(565, 299);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(253, 129);
            panel5.TabIndex = 13;
            // 
            // generadorCurp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCurp);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "generadorCurp";
            Size = new Size(822, 503);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtApellidoMaterno;
        private TextBox txtApellidoPaterno;
        private Label lblSexo;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblFecha;
        private Panel panel3;
        private Label lblEntidadFederativa;
        private Panel panel4;
        private ComboBox cboEntidadFederativa;
        private Button btnGenerar;
        private Label lblCurp;
        private Panel panel5;
        private ComboBox cboSexo;
    }
}
