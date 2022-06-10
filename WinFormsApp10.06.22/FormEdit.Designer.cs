
namespace WinFormsApp10._06._22
{
    partial class FormEdit
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
            this.textForEdition = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textForEdition
            // 
            this.textForEdition.Location = new System.Drawing.Point(60, 35);
            this.textForEdition.Multiline = true;
            this.textForEdition.Name = "textForEdition";
            this.textForEdition.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textForEdition.Size = new System.Drawing.Size(403, 93);
            this.textForEdition.TabIndex = 0;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(72, 172);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 1;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Cancel.Location = new System.Drawing.Point(259, 171);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Отменить";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.textForEdition);
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        public System.Windows.Forms.TextBox textForEdition;
    }
}