namespace BinaryReader
{
    partial class FrmBinaryManager
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
            this.lblOrigen = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.lblEscribirOffset = new System.Windows.Forms.Label();
            this.nudOffset = new System.Windows.Forms.NumericUpDown();
            this.txtEscribirBytes = new System.Windows.Forms.TextBox();
            this.lblEscribirBytes = new System.Windows.Forms.Label();
            this.lblEscribirOffsetHexa = new System.Windows.Forms.Label();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.gbCOPIA = new System.Windows.Forms.GroupBox();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.lblArchivoDestinoFormato = new System.Windows.Forms.Label();
            this.rbTexto = new System.Windows.Forms.RadioButton();
            this.rbBinario = new System.Windows.Forms.RadioButton();
            this.lblBytes = new System.Windows.Forms.Label();
            this.nudBytes = new System.Windows.Forms.NumericUpDown();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.gbEscribir = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).BeginInit();
            this.gbCOPIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBytes)).BeginInit();
            this.gbEscribir.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(28, 9);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(112, 20);
            this.lblOrigen.TabIndex = 3;
            this.lblOrigen.Text = "Archivo Origen";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigen.Location = new System.Drawing.Point(171, 6);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(624, 26);
            this.txtOrigen.TabIndex = 4;
            // 
            // lblEscribirOffset
            // 
            this.lblEscribirOffset.AutoSize = true;
            this.lblEscribirOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscribirOffset.Location = new System.Drawing.Point(9, 72);
            this.lblEscribirOffset.Name = "lblEscribirOffset";
            this.lblEscribirOffset.Size = new System.Drawing.Size(188, 20);
            this.lblEscribirOffset.TabIndex = 10;
            this.lblEscribirOffset.Text = "Escritura Offset (decimal)";
            // 
            // nudOffset
            // 
            this.nudOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudOffset.Location = new System.Drawing.Point(203, 70);
            this.nudOffset.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.nudOffset.Name = "nudOffset";
            this.nudOffset.Size = new System.Drawing.Size(120, 26);
            this.nudOffset.TabIndex = 9;
            this.nudOffset.Value = new decimal(new int[] {
            388,
            0,
            0,
            0});
            this.nudOffset.ValueChanged += new System.EventHandler(this.nudOffset_ValueChanged);
            // 
            // txtEscribirBytes
            // 
            this.txtEscribirBytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEscribirBytes.Location = new System.Drawing.Point(203, 28);
            this.txtEscribirBytes.Name = "txtEscribirBytes";
            this.txtEscribirBytes.Size = new System.Drawing.Size(576, 26);
            this.txtEscribirBytes.TabIndex = 12;
            this.txtEscribirBytes.Text = "00 00 00 00";
            // 
            // lblEscribirBytes
            // 
            this.lblEscribirBytes.AutoSize = true;
            this.lblEscribirBytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscribirBytes.Location = new System.Drawing.Point(8, 31);
            this.lblEscribirBytes.Name = "lblEscribirBytes";
            this.lblEscribirBytes.Size = new System.Drawing.Size(164, 20);
            this.lblEscribirBytes.TabIndex = 11;
            this.lblEscribirBytes.Text = "Escritura Bytes (hexa)";
            // 
            // lblEscribirOffsetHexa
            // 
            this.lblEscribirOffsetHexa.AutoSize = true;
            this.lblEscribirOffsetHexa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscribirOffsetHexa.Location = new System.Drawing.Point(329, 72);
            this.lblEscribirOffsetHexa.Name = "lblEscribirOffsetHexa";
            this.lblEscribirOffsetHexa.Size = new System.Drawing.Size(25, 20);
            this.lblEscribirOffsetHexa.TabIndex = 13;
            this.lblEscribirOffsetHexa.Text = "0x";
            // 
            // btnEscribir
            // 
            this.btnEscribir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscribir.Location = new System.Drawing.Point(603, 70);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(176, 40);
            this.btnEscribir.TabIndex = 17;
            this.btnEscribir.Text = "ESCRBIR";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // gbCOPIA
            // 
            this.gbCOPIA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCOPIA.Controls.Add(this.btnCopiar);
            this.gbCOPIA.Controls.Add(this.lblArchivoDestinoFormato);
            this.gbCOPIA.Controls.Add(this.rbTexto);
            this.gbCOPIA.Controls.Add(this.rbBinario);
            this.gbCOPIA.Controls.Add(this.lblBytes);
            this.gbCOPIA.Controls.Add(this.nudBytes);
            this.gbCOPIA.Controls.Add(this.txtDestino);
            this.gbCOPIA.Controls.Add(this.lblDestino);
            this.gbCOPIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCOPIA.Location = new System.Drawing.Point(15, 50);
            this.gbCOPIA.Name = "gbCOPIA";
            this.gbCOPIA.Size = new System.Drawing.Size(786, 154);
            this.gbCOPIA.TabIndex = 19;
            this.gbCOPIA.TabStop = false;
            this.gbCOPIA.Text = "COPIAR ENCABEZADO";
            // 
            // btnCopiar
            // 
            this.btnCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiar.Location = new System.Drawing.Point(604, 107);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(176, 40);
            this.btnCopiar.TabIndex = 26;
            this.btnCopiar.Text = "COPIAR";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // lblArchivoDestinoFormato
            // 
            this.lblArchivoDestinoFormato.AutoSize = true;
            this.lblArchivoDestinoFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivoDestinoFormato.Location = new System.Drawing.Point(13, 107);
            this.lblArchivoDestinoFormato.Name = "lblArchivoDestinoFormato";
            this.lblArchivoDestinoFormato.Size = new System.Drawing.Size(128, 20);
            this.lblArchivoDestinoFormato.TabIndex = 25;
            this.lblArchivoDestinoFormato.Text = "Formato Destino";
            // 
            // rbTexto
            // 
            this.rbTexto.AutoSize = true;
            this.rbTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTexto.Location = new System.Drawing.Point(263, 105);
            this.rbTexto.Name = "rbTexto";
            this.rbTexto.Size = new System.Drawing.Size(79, 24);
            this.rbTexto.TabIndex = 24;
            this.rbTexto.TabStop = true;
            this.rbTexto.Text = "TEXTO";
            this.rbTexto.UseVisualStyleBackColor = true;
            // 
            // rbBinario
            // 
            this.rbBinario.AutoSize = true;
            this.rbBinario.Checked = true;
            this.rbBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBinario.Location = new System.Drawing.Point(157, 105);
            this.rbBinario.Name = "rbBinario";
            this.rbBinario.Size = new System.Drawing.Size(94, 24);
            this.rbBinario.TabIndex = 23;
            this.rbBinario.TabStop = true;
            this.rbBinario.Text = "BINARIO";
            this.rbBinario.UseVisualStyleBackColor = true;
            // 
            // lblBytes
            // 
            this.lblBytes.AutoSize = true;
            this.lblBytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBytes.Location = new System.Drawing.Point(13, 28);
            this.lblBytes.Name = "lblBytes";
            this.lblBytes.Size = new System.Drawing.Size(137, 20);
            this.lblBytes.TabIndex = 22;
            this.lblBytes.Text = "Cantidad de bytes";
            // 
            // nudBytes
            // 
            this.nudBytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBytes.Location = new System.Drawing.Point(157, 28);
            this.nudBytes.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.nudBytes.Name = "nudBytes";
            this.nudBytes.Size = new System.Drawing.Size(120, 26);
            this.nudBytes.TabIndex = 21;
            this.nudBytes.Value = new decimal(new int[] {
            2098176,
            0,
            0,
            0});
            // 
            // txtDestino
            // 
            this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.Location = new System.Drawing.Point(157, 63);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(623, 26);
            this.txtDestino.TabIndex = 20;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(13, 63);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(120, 20);
            this.lblDestino.TabIndex = 19;
            this.lblDestino.Text = "Archivo Destino";
            // 
            // gbEscribir
            // 
            this.gbEscribir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEscribir.Controls.Add(this.txtEscribirBytes);
            this.gbEscribir.Controls.Add(this.nudOffset);
            this.gbEscribir.Controls.Add(this.btnEscribir);
            this.gbEscribir.Controls.Add(this.lblEscribirOffset);
            this.gbEscribir.Controls.Add(this.lblEscribirBytes);
            this.gbEscribir.Controls.Add(this.lblEscribirOffsetHexa);
            this.gbEscribir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEscribir.Location = new System.Drawing.Point(16, 210);
            this.gbEscribir.Name = "gbEscribir";
            this.gbEscribir.Size = new System.Drawing.Size(794, 123);
            this.gbEscribir.TabIndex = 20;
            this.gbEscribir.TabStop = false;
            this.gbEscribir.Text = "ESCRIBIR BYTES";
            // 
            // FrmBinaryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 339);
            this.Controls.Add(this.gbEscribir);
            this.Controls.Add(this.gbCOPIA);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.lblOrigen);
            this.Name = "FrmBinaryManager";
            this.Text = "Binary Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).EndInit();
            this.gbCOPIA.ResumeLayout(false);
            this.gbCOPIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBytes)).EndInit();
            this.gbEscribir.ResumeLayout(false);
            this.gbEscribir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label lblEscribirOffset;
        private System.Windows.Forms.NumericUpDown nudOffset;
        private System.Windows.Forms.TextBox txtEscribirBytes;
        private System.Windows.Forms.Label lblEscribirBytes;
        private System.Windows.Forms.Label lblEscribirOffsetHexa;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.GroupBox gbCOPIA;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Label lblArchivoDestinoFormato;
        private System.Windows.Forms.RadioButton rbTexto;
        private System.Windows.Forms.RadioButton rbBinario;
        private System.Windows.Forms.Label lblBytes;
        private System.Windows.Forms.NumericUpDown nudBytes;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.GroupBox gbEscribir;
    }
}

