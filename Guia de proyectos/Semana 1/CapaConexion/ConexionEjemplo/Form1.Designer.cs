namespace ConexionEjemplo
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
            this.btnCargar = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tboxCustomerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxCompanyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxContactTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.tboxContacName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(12, 377);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(160, 61);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar Informacion";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 60);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(1061, 302);
            this.dataGrid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtro de Informacion";
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(249, 22);
            this.tbFiltro.Multiline = true;
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(245, 25);
            this.tbFiltro.TabIndex = 3;
            this.tbFiltro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(1262, 50);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(172, 25);
            this.txtBuscar.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1109, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customers ID:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(1200, 94);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(137, 36);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar Cliente";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tboxCustomerID
            // 
            this.tboxCustomerID.Location = new System.Drawing.Point(1262, 150);
            this.tboxCustomerID.Multiline = true;
            this.tboxCustomerID.Name = "tboxCustomerID";
            this.tboxCustomerID.Size = new System.Drawing.Size(172, 25);
            this.tboxCustomerID.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1101, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customers ID:";
            // 
            // tboxCompanyName
            // 
            this.tboxCompanyName.Location = new System.Drawing.Point(1262, 185);
            this.tboxCompanyName.Multiline = true;
            this.tboxCompanyName.Name = "tboxCompanyName";
            this.tboxCompanyName.Size = new System.Drawing.Size(172, 25);
            this.tboxCompanyName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1083, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Company Name:";
            // 
            // tboxContactTitle
            // 
            this.tboxContactTitle.Location = new System.Drawing.Point(1262, 254);
            this.tboxContactTitle.Multiline = true;
            this.tboxContactTitle.Name = "tboxContactTitle";
            this.tboxContactTitle.Size = new System.Drawing.Size(172, 25);
            this.tboxContactTitle.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(1109, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contact Title:";
            // 
            // tboxAddress
            // 
            this.tboxAddress.Location = new System.Drawing.Point(1262, 291);
            this.tboxAddress.Multiline = true;
            this.tboxAddress.Name = "tboxAddress";
            this.tboxAddress.Size = new System.Drawing.Size(172, 25);
            this.tboxAddress.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(1152, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Address:";
            // 
            // tboxCity
            // 
            this.tboxCity.Location = new System.Drawing.Point(1262, 328);
            this.tboxCity.Multiline = true;
            this.tboxCity.Name = "tboxCity";
            this.tboxCity.Size = new System.Drawing.Size(172, 25);
            this.tboxCity.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(1195, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "City:";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(1216, 377);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(121, 37);
            this.btnInsertar.TabIndex = 17;
            this.btnInsertar.Text = "Ingresar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // tboxContacName
            // 
            this.tboxContacName.Location = new System.Drawing.Point(1262, 219);
            this.tboxContacName.Multiline = true;
            this.tboxContacName.Name = "tboxContacName";
            this.tboxContacName.Size = new System.Drawing.Size(172, 25);
            this.tboxContacName.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(1104, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "ContactName:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 450);
            this.Controls.Add(this.tboxContacName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.tboxCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tboxAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tboxContactTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tboxCompanyName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxCustomerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnCargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tboxCustomerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxCompanyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxContactTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox tboxContacName;
        private System.Windows.Forms.Label label8;
    }
}

