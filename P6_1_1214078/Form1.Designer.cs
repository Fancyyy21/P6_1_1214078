namespace P6_1_1214078
{
    partial class MaulanaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.vbButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.csButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(729, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which do you think is better, Visual Basic or C#?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vbButton
            // 
            this.vbButton.Location = new System.Drawing.Point(237, 198);
            this.vbButton.Name = "vbButton";
            this.vbButton.Size = new System.Drawing.Size(114, 40);
            this.vbButton.TabIndex = 1;
            this.vbButton.Text = "Visual Basic";
            this.vbButton.UseVisualStyleBackColor = true;
            this.vbButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.vbButton_MouseMove);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(47, 386);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(95, 34);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // csButton
            // 
            this.csButton.Location = new System.Drawing.Point(455, 198);
            this.csButton.Name = "csButton";
            this.csButton.Size = new System.Drawing.Size(114, 40);
            this.csButton.TabIndex = 3;
            this.csButton.Text = "C#";
            this.csButton.UseVisualStyleBackColor = true;
            this.csButton.Click += new System.EventHandler(this.csButton_Click);
            // 
            // MaulanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.csButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.vbButton);
            this.Controls.Add(this.label1);
            this.Name = "MaulanaForm";
            this.Text = "MaulanaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vbButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button csButton;
    }
}

