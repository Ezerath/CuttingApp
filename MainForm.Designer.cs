namespace CuttingApp
{
    partial class MainForm
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
            this.addMaterialButton = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.addDetailButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addMaterialButton
            // 
            this.addMaterialButton.Location = new System.Drawing.Point(759, 23);
            this.addMaterialButton.Name = "addMaterialButton";
            this.addMaterialButton.Size = new System.Drawing.Size(75, 72);
            this.addMaterialButton.TabIndex = 1;
            this.addMaterialButton.Text = "Добавить\r\nматериал";
            this.addMaterialButton.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(13, 23);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(728, 397);
            this.panel.TabIndex = 2;
            // 
            // addDetailButton
            // 
            this.addDetailButton.Location = new System.Drawing.Point(759, 101);
            this.addDetailButton.Name = "addDetailButton";
            this.addDetailButton.Size = new System.Drawing.Size(75, 70);
            this.addDetailButton.TabIndex = 3;
            this.addDetailButton.Text = "Добавить\r\nдеталь";
            this.addDetailButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(886, 450);
            this.Controls.Add(this.addDetailButton);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.addMaterialButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CuttingApp";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addMaterialButton;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button addDetailButton;
    }
}

