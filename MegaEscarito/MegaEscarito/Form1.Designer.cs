namespace MegaEscarito
{
    partial class Form1
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
            this.hdrDeskOrder = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblDrawerCount = new System.Windows.Forms.Label();
            this.lblDeskMaterial = new System.Windows.Forms.Label();
            this.material = new System.Windows.Forms.ListBox();
            this.drawerCount = new System.Windows.Forms.NumericUpDown();
            this.width = new System.Windows.Forms.TextBox();
            this.length = new System.Windows.Forms.TextBox();
            this.lblOrderDays = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.orderDays = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawerCount)).BeginInit();
            this.SuspendLayout();
            // 
            // hdrDeskOrder
            // 
            this.hdrDeskOrder.AutoSize = true;
            this.hdrDeskOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.hdrDeskOrder.Location = new System.Drawing.Point(16, 11);
            this.hdrDeskOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hdrDeskOrder.Name = "hdrDeskOrder";
            this.hdrDeskOrder.Size = new System.Drawing.Size(262, 29);
            this.hdrDeskOrder.TabIndex = 0;
            this.hdrDeskOrder.Text = "Desk Order Application";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(16, 52);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(104, 17);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width in inches";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(188, 52);
            this.lblLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(112, 17);
            this.lblLength.TabIndex = 2;
            this.lblLength.Text = "Length in inches";
            // 
            // lblDrawerCount
            // 
            this.lblDrawerCount.AutoSize = true;
            this.lblDrawerCount.Location = new System.Drawing.Point(16, 112);
            this.lblDrawerCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDrawerCount.Name = "lblDrawerCount";
            this.lblDrawerCount.Size = new System.Drawing.Size(87, 17);
            this.lblDrawerCount.TabIndex = 3;
            this.lblDrawerCount.Text = "Dawer count";
            // 
            // lblDeskMaterial
            // 
            this.lblDeskMaterial.AutoSize = true;
            this.lblDeskMaterial.Location = new System.Drawing.Point(187, 113);
            this.lblDeskMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeskMaterial.Name = "lblDeskMaterial";
            this.lblDeskMaterial.Size = new System.Drawing.Size(58, 17);
            this.lblDeskMaterial.TabIndex = 4;
            this.lblDeskMaterial.Text = "Material";
            // 
            // material
            // 
            this.material.FormattingEnabled = true;
            this.material.ItemHeight = 16;
            this.material.Location = new System.Drawing.Point(191, 133);
            this.material.Margin = new System.Windows.Forms.Padding(4);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(108, 68);
            this.material.TabIndex = 4;
            this.material.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // drawerCount
            // 
            this.drawerCount.Location = new System.Drawing.Point(15, 133);
            this.drawerCount.Margin = new System.Windows.Forms.Padding(4);
            this.drawerCount.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawerCount.Name = "drawerCount";
            this.drawerCount.Size = new System.Drawing.Size(123, 22);
            this.drawerCount.TabIndex = 3;
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(15, 73);
            this.width.Margin = new System.Windows.Forms.Padding(4);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(105, 22);
            this.width.TabIndex = 1;
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(190, 73);
            this.length.Margin = new System.Windows.Forms.Padding(4);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(108, 22);
            this.length.TabIndex = 2;
            // 
            // lblOrderDays
            // 
            this.lblOrderDays.AutoSize = true;
            this.lblOrderDays.Location = new System.Drawing.Point(18, 207);
            this.lblOrderDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderDays.Name = "lblOrderDays";
            this.lblOrderDays.Size = new System.Drawing.Size(79, 17);
            this.lblOrderDays.TabIndex = 11;
            this.lblOrderDays.Text = "Order days";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(249, 297);
            this.submit.Margin = new System.Windows.Forms.Padding(4);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(100, 28);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Out put order";
            // 
            // orderDays
            // 
            this.orderDays.FormattingEnabled = true;
            this.orderDays.Location = new System.Drawing.Point(19, 227);
            this.orderDays.Name = "orderDays";
            this.orderDays.Size = new System.Drawing.Size(155, 24);
            this.orderDays.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 352);
            this.Controls.Add(this.orderDays);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.lblOrderDays);
            this.Controls.Add(this.length);
            this.Controls.Add(this.width);
            this.Controls.Add(this.drawerCount);
            this.Controls.Add(this.material);
            this.Controls.Add(this.lblDeskMaterial);
            this.Controls.Add(this.lblDrawerCount);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.hdrDeskOrder);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Mega Escritorio";
            ((System.ComponentModel.ISupportInitialize)(this.drawerCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hdrDeskOrder;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblDrawerCount;
        private System.Windows.Forms.Label lblDeskMaterial;
        private System.Windows.Forms.ListBox material;
        private System.Windows.Forms.NumericUpDown drawerCount;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.Label lblOrderDays;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox orderDays;
    }
}

