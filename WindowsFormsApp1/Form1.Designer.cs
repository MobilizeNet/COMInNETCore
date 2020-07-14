namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.axMSFlexGrid2 = new AxMSFlexGridLib.AxMSFlexGrid();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axMSFlexGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 820);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(588, 140);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // axMSFlexGrid2
            // 
            this.axMSFlexGrid2.Location = new System.Drawing.Point(63, 52);
            this.axMSFlexGrid2.Margin = new System.Windows.Forms.Padding(6);
            this.axMSFlexGrid2.Name = "axMSFlexGrid2";
            this.axMSFlexGrid2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMSFlexGrid2.OcxState")));
            this.axMSFlexGrid2.Size = new System.Drawing.Size(692, 485);
            this.axMSFlexGrid2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(785, 823);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(437, 136);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1568, 1148);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axMSFlexGrid2);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axMSFlexGrid2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxMSFlexGridLib.AxMSFlexGrid axMSFlexGrid1;
        private System.Windows.Forms.Button button1;
        private AxMSFlexGridLib.AxMSFlexGrid axMSFlexGrid2;
        private System.Windows.Forms.Button button2;
    }
}

