namespace CapaDesconectada
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btBuscarPorIdNt = new System.Windows.Forms.Button();
            this.tboxObtenerNt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnObtenerNotipado = new System.Windows.Forms.Button();
            this.gridNotipado = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarTipado = new System.Windows.Forms.Button();
            this.tboxBuscarTipado = new System.Windows.Forms.TextBox();
            this.btnObtenerTipado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridTipado = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotipado)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btBuscarPorIdNt);
            this.groupBox1.Controls.Add(this.tboxObtenerNt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnObtenerNotipado);
            this.groupBox1.Controls.Add(this.gridNotipado);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 459);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DataSet No Tipado";
            // 
            // btBuscarPorIdNt
            // 
            this.btBuscarPorIdNt.Location = new System.Drawing.Point(43, 418);
            this.btBuscarPorIdNt.Name = "btBuscarPorIdNt";
            this.btBuscarPorIdNt.Size = new System.Drawing.Size(264, 35);
            this.btBuscarPorIdNt.TabIndex = 5;
            this.btBuscarPorIdNt.Text = "Enviar";
            this.btBuscarPorIdNt.UseVisualStyleBackColor = true;
            this.btBuscarPorIdNt.Click += new System.EventHandler(this.btBuscarPorIdNt_Click);
            // 
            // tboxObtenerNt
            // 
            this.tboxObtenerNt.Location = new System.Drawing.Point(91, 377);
            this.tboxObtenerNt.Name = "tboxObtenerNt";
            this.tboxObtenerNt.Size = new System.Drawing.Size(216, 20);
            this.tboxObtenerNt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer ID ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnObtenerNotipado
            // 
            this.btnObtenerNotipado.Location = new System.Drawing.Point(6, 300);
            this.btnObtenerNotipado.Name = "btnObtenerNotipado";
            this.btnObtenerNotipado.Size = new System.Drawing.Size(325, 49);
            this.btnObtenerNotipado.TabIndex = 1;
            this.btnObtenerNotipado.Text = "Obtener dato no tipado";
            this.btnObtenerNotipado.UseVisualStyleBackColor = true;
            this.btnObtenerNotipado.Click += new System.EventHandler(this.btnObtenerNotipado_Click);
            // 
            // gridNotipado
            // 
            this.gridNotipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNotipado.Location = new System.Drawing.Point(0, 48);
            this.gridNotipado.Name = "gridNotipado";
            this.gridNotipado.Size = new System.Drawing.Size(337, 220);
            this.gridNotipado.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarTipado);
            this.groupBox2.Controls.Add(this.tboxBuscarTipado);
            this.groupBox2.Controls.Add(this.btnObtenerTipado);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.gridTipado);
            this.groupBox2.Location = new System.Drawing.Point(428, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 459);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DataSet Tipado";
            // 
            // btnBuscarTipado
            // 
            this.btnBuscarTipado.Location = new System.Drawing.Point(42, 418);
            this.btnBuscarTipado.Name = "btnBuscarTipado";
            this.btnBuscarTipado.Size = new System.Drawing.Size(264, 35);
            this.btnBuscarTipado.TabIndex = 8;
            this.btnBuscarTipado.Text = "Enviar";
            this.btnBuscarTipado.UseVisualStyleBackColor = true;
            this.btnBuscarTipado.Click += new System.EventHandler(this.btnBuscarTipado_Click);
            // 
            // tboxBuscarTipado
            // 
            this.tboxBuscarTipado.Location = new System.Drawing.Point(90, 377);
            this.tboxBuscarTipado.Name = "tboxBuscarTipado";
            this.tboxBuscarTipado.Size = new System.Drawing.Size(216, 20);
            this.tboxBuscarTipado.TabIndex = 7;
            // 
            // btnObtenerTipado
            // 
            this.btnObtenerTipado.Location = new System.Drawing.Point(-1, 300);
            this.btnObtenerTipado.Name = "btnObtenerTipado";
            this.btnObtenerTipado.Size = new System.Drawing.Size(337, 49);
            this.btnObtenerTipado.TabIndex = 2;
            this.btnObtenerTipado.Text = "obtener dato tipado";
            this.btnObtenerTipado.UseVisualStyleBackColor = true;
            this.btnObtenerTipado.Click += new System.EventHandler(this.btnObtenerTipado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer ID ";
            // 
            // gridTipado
            // 
            this.gridTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTipado.Location = new System.Drawing.Point(0, 48);
            this.gridTipado.Name = "gridTipado";
            this.gridTipado.Size = new System.Drawing.Size(337, 220);
            this.gridTipado.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotipado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridNotipado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnObtenerNotipado;
        private System.Windows.Forms.Button btnObtenerTipado;
        private System.Windows.Forms.DataGridView gridTipado;
        private System.Windows.Forms.Button btBuscarPorIdNt;
        private System.Windows.Forms.TextBox tboxObtenerNt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarTipado;
        private System.Windows.Forms.TextBox tboxBuscarTipado;
        private System.Windows.Forms.Label label1;
    }
}

