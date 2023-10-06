namespace Calculadora_de_Lautaro_Marguery
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
            cmbOperacion = new ComboBox();
            txtSegundoOperando = new TextBox();
            txtPrimerOperando = new TextBox();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            lblPrimerOperador = new Label();
            lblOperacion = new Label();
            lblSegundoOperador = new Label();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            lblResultado = new Label();
            grpSistema = new GroupBox();
            lblFResultado = new Label();
            lstHistorial = new ListBox();
            lblHistorial = new Label();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // cmbOperacion
            // 
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(326, 240);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(121, 23);
            cmbOperacion.TabIndex = 0;
            cmbOperacion.SelectedIndexChanged += cmbOperacion_SelectedIndexChanged;
            // 
            // txtSegundoOperando
            // 
            txtSegundoOperando.Location = new Point(501, 240);
            txtSegundoOperando.Name = "txtSegundoOperando";
            txtSegundoOperando.Size = new Size(140, 23);
            txtSegundoOperando.TabIndex = 1;
            txtSegundoOperando.TextChanged += txtSegundoOperador_TextChanged;
            // 
            // txtPrimerOperando
            // 
            txtPrimerOperando.Location = new Point(142, 240);
            txtPrimerOperando.Name = "txtPrimerOperando";
            txtPrimerOperando.Size = new Size(140, 23);
            txtPrimerOperando.TabIndex = 2;
            txtPrimerOperando.TextChanged += txtPrimerOperador_TextChanged;
            // 
            // btnOperar
            // 
            btnOperar.Location = new Point(142, 290);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(140, 38);
            btnOperar.TabIndex = 3;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(326, 290);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(140, 38);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(501, 290);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(140, 38);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Location = new Point(142, 201);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(115, 15);
            lblPrimerOperador.TabIndex = 6;
            lblPrimerOperador.Text = "PRIMER OPERADOR:";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Location = new Point(332, 201);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(76, 15);
            lblOperacion.TabIndex = 7;
            lblOperacion.Text = "OPERACION:";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Location = new Point(501, 201);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(128, 15);
            lblSegundoOperador.TabIndex = 8;
            lblSegundoOperador.Text = "SEGUNDO OPERADOR:";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(6, 48);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(62, 19);
            rdbBinario.TabIndex = 9;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(108, 48);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(68, 19);
            rdbDecimal.TabIndex = 10;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(12, 9);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(243, 62);
            lblResultado.TabIndex = 11;
            lblResultado.Text = "Resultado:";
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Location = new Point(304, 55);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(200, 100);
            grpSistema.TabIndex = 12;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            // 
            // lblFResultado
            // 
            lblFResultado.AutoSize = true;
            lblFResultado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblFResultado.Location = new Point(26, 103);
            lblFResultado.Name = "lblFResultado";
            lblFResultado.Size = new Size(0, 37);
            lblFResultado.TabIndex = 13;
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 15;
            lstHistorial.Location = new Point(670, 124);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(255, 244);
            lstHistorial.TabIndex = 14;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Location = new Point(670, 85);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(63, 15);
            lblHistorial.TabIndex = 15;
            lblHistorial.Text = "HISTORIAL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 380);
            Controls.Add(lblHistorial);
            Controls.Add(lstHistorial);
            Controls.Add(lblFResultado);
            Controls.Add(grpSistema);
            Controls.Add(lblResultado);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperador);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(txtPrimerOperando);
            Controls.Add(txtSegundoOperando);
            Controls.Add(cmbOperacion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Lauty";
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOperacion;
        private TextBox txtSegundoOperando;
        private TextBox txtPrimerOperando;
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private Label lblPrimerOperador;
        private Label lblOperacion;
        private Label lblSegundoOperador;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private Label lblResultado;
        private GroupBox grpSistema;
        private Label lblFResultado;
        private ListBox lstHistorial;
        private Label lblHistorial;
    }
}