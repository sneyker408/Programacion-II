namespace CapaDesconectada
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.northwind = new CapaDesconectada.Northwind();
            this.northwindBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.northwindBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.northwind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // northwind
            // 
            this.northwind.DataSetName = "Northwind";
            this.northwind.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // northwindBindingSource
            // 
            this.northwindBindingSource.DataSource = this.northwind;
            this.northwindBindingSource.Position = 0;
            // 
            // northwindBindingSource1
            // 
            this.northwindBindingSource1.DataSource = this.northwind;
            this.northwindBindingSource1.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.northwindBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(283, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // northwindBindingSource2
            // 
            this.northwindBindingSource2.DataSource = this.northwind;
            this.northwindBindingSource2.Position = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.northwind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource northwindBindingSource;
        private Northwind northwind;
        private System.Windows.Forms.BindingSource northwindBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource northwindBindingSource2;
    }
}