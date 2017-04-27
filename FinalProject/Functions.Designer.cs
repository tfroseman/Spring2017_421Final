namespace FinalProject
{
    partial class Functions
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
            this.build = new System.Windows.Forms.Button();
            this.studentsbutton = new System.Windows.Forms.Button();
            this.classesbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // build
            // 
            this.build.Location = new System.Drawing.Point(12, 12);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(92, 23);
            this.build.TabIndex = 0;
            this.build.Text = "Build Database";
            this.build.UseVisualStyleBackColor = true;
            this.build.Click += new System.EventHandler(this.build_Click);
            // 
            // studentsbutton
            // 
            this.studentsbutton.Location = new System.Drawing.Point(110, 12);
            this.studentsbutton.Name = "studentsbutton";
            this.studentsbutton.Size = new System.Drawing.Size(90, 23);
            this.studentsbutton.TabIndex = 1;
            this.studentsbutton.Text = "List Students";
            this.studentsbutton.UseVisualStyleBackColor = true;
            this.studentsbutton.Click += new System.EventHandler(this.studentsbutton_Click);
            // 
            // classesbutton
            // 
            this.classesbutton.Location = new System.Drawing.Point(206, 12);
            this.classesbutton.Name = "classesbutton";
            this.classesbutton.Size = new System.Drawing.Size(75, 23);
            this.classesbutton.TabIndex = 2;
            this.classesbutton.Text = "List Classes";
            this.classesbutton.UseVisualStyleBackColor = true;
            this.classesbutton.Click += new System.EventHandler(this.classesbutton_Click);
            // 
            // Functions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 262);
            this.Controls.Add(this.classesbutton);
            this.Controls.Add(this.studentsbutton);
            this.Controls.Add(this.build);
            this.Name = "Functions";
            this.Text = "Functions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button build;
        private System.Windows.Forms.Button studentsbutton;
        private System.Windows.Forms.Button classesbutton;
    }
}