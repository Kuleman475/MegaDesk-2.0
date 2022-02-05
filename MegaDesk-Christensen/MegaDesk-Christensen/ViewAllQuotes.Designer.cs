namespace MegaDesk_Christensen
{
    partial class ViewAllQuotes
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rushOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desktopMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rushNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskQuoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(247, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.rushOrderDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.depthDataGridViewTextBoxColumn,
            this.drawersDataGridViewTextBoxColumn,
            this.desktopMaterialDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.rushNumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deskQuoteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 281);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // rushOrderDataGridViewTextBoxColumn
            // 
            this.rushOrderDataGridViewTextBoxColumn.DataPropertyName = "RushOrder";
            this.rushOrderDataGridViewTextBoxColumn.HeaderText = "RushOrder";
            this.rushOrderDataGridViewTextBoxColumn.Name = "rushOrderDataGridViewTextBoxColumn";
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "Width";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            // 
            // depthDataGridViewTextBoxColumn
            // 
            this.depthDataGridViewTextBoxColumn.DataPropertyName = "Depth";
            this.depthDataGridViewTextBoxColumn.HeaderText = "Depth";
            this.depthDataGridViewTextBoxColumn.Name = "depthDataGridViewTextBoxColumn";
            // 
            // drawersDataGridViewTextBoxColumn
            // 
            this.drawersDataGridViewTextBoxColumn.DataPropertyName = "Drawers";
            this.drawersDataGridViewTextBoxColumn.HeaderText = "Drawers";
            this.drawersDataGridViewTextBoxColumn.Name = "drawersDataGridViewTextBoxColumn";
            // 
            // desktopMaterialDataGridViewTextBoxColumn
            // 
            this.desktopMaterialDataGridViewTextBoxColumn.DataPropertyName = "DesktopMaterial";
            this.desktopMaterialDataGridViewTextBoxColumn.HeaderText = "DesktopMaterial";
            this.desktopMaterialDataGridViewTextBoxColumn.Name = "desktopMaterialDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // rushNumDataGridViewTextBoxColumn
            // 
            this.rushNumDataGridViewTextBoxColumn.DataPropertyName = "rushNum";
            this.rushNumDataGridViewTextBoxColumn.HeaderText = "rushNum";
            this.rushNumDataGridViewTextBoxColumn.Name = "rushNumDataGridViewTextBoxColumn";
            // 
            // deskQuoteBindingSource
            // 
            this.deskQuoteBindingSource.DataSource = typeof(MegaDesk_Christensen.DeskQuote);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "ViewAllQuotes";
            this.Text = "View All Quotes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentRushComboDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource deskQuoteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rushOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desktopMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rushNumDataGridViewTextBoxColumn;
    }
}