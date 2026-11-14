namespace BasicCalculator
{
    partial class frmBasicCalculator
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
            label1 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            cmbOperator = new ComboBox();
            btnCompute = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(203, 37);
            label1.TabIndex = 0;
            label1.Text = "Basic Calculator";
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum1.Location = new Point(12, 61);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(244, 29);
            txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum2.Location = new Point(12, 133);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(244, 29);
            txtNum2.TabIndex = 2;
            // 
            // cmbOperator
            // 
            cmbOperator.FormattingEnabled = true;
            cmbOperator.Location = new Point(12, 104);
            cmbOperator.Name = "cmbOperator";
            cmbOperator.Size = new Size(121, 23);
            cmbOperator.TabIndex = 3;
            // 
            // btnCompute
            // 
            btnCompute.Location = new Point(12, 182);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(75, 39);
            btnCompute.TabIndex = 5;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = SystemColors.ActiveBorder;
            lblResult.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(152, 184);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(99, 37);
            lblResult.TabIndex = 6;
            lblResult.Text = "*Result";
            // 
            // frmBasicCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 271);
            Controls.Add(lblResult);
            Controls.Add(btnCompute);
            Controls.Add(cmbOperator);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label1);
            Name = "frmBasicCalculator";
            Text = "BASIC CALCULATOR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private ComboBox cmbOperator;
        private Button btnCompute;
        private Label lblResult;
    }
}
