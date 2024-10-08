namespace EFDemo
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnObtenerTodos = new System.Windows.Forms.Button();
            this.txbObtenerTodos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(776, 236);
            this.dgvCustomers.TabIndex = 0;
            // 
            // btnObtenerTodos
            // 
            this.btnObtenerTodos.Location = new System.Drawing.Point(312, 254);
            this.btnObtenerTodos.Name = "btnObtenerTodos";
            this.btnObtenerTodos.Size = new System.Drawing.Size(140, 45);
            this.btnObtenerTodos.TabIndex = 1;
            this.btnObtenerTodos.Text = "Cargar Informacion";
            this.btnObtenerTodos.UseVisualStyleBackColor = true;
            this.btnObtenerTodos.Click += new System.EventHandler(this.btnObtenerTodos_Click);
            // 
            // txbObtenerTodos
            // 
            this.txbObtenerTodos.Location = new System.Drawing.Point(79, 283);
            this.txbObtenerTodos.Name = "txbObtenerTodos";
            this.txbObtenerTodos.Size = new System.Drawing.Size(100, 20);
            this.txbObtenerTodos.TabIndex = 0;
            this.txbObtenerTodos.TextChanged += new System.EventHandler(this.txbObtenerTodos_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IDCustomer";
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(199, 281);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(75, 23);
            this.btnTodos.TabIndex = 2;
            this.btnTodos.Text = "Obtener";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbObtenerTodos);
            this.Controls.Add(this.btnObtenerTodos);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnObtenerTodos;
        private System.Windows.Forms.TextBox txbObtenerTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTodos;
    }
}

