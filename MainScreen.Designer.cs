namespace Disaster_Recovery_Solution
{
    partial class MainScreen
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
            this.label2 = new System.Windows.Forms.Label();
            this.calcEngineButton = new System.Windows.Forms.Button();
            this.entityCreatorButton = new System.Windows.Forms.Button();
            this.formBuilderButton = new System.Windows.Forms.Button();
            this.exitAppButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(496, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome to Disaster Recovery Solutions...";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // calcEngineButton
            // 
            this.calcEngineButton.Location = new System.Drawing.Point(109, 155);
            this.calcEngineButton.Name = "calcEngineButton";
            this.calcEngineButton.Size = new System.Drawing.Size(125, 47);
            this.calcEngineButton.TabIndex = 1;
            this.calcEngineButton.Text = "Calc Engine";
            this.calcEngineButton.UseVisualStyleBackColor = true;
            this.calcEngineButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // entityCreatorButton
            // 
            this.entityCreatorButton.Location = new System.Drawing.Point(287, 155);
            this.entityCreatorButton.Name = "entityCreatorButton";
            this.entityCreatorButton.Size = new System.Drawing.Size(125, 47);
            this.entityCreatorButton.TabIndex = 2;
            this.entityCreatorButton.Text = "Entity Creator";
            this.entityCreatorButton.UseVisualStyleBackColor = true;
            // 
            // formBuilderButton
            // 
            this.formBuilderButton.Location = new System.Drawing.Point(468, 155);
            this.formBuilderButton.Name = "formBuilderButton";
            this.formBuilderButton.Size = new System.Drawing.Size(125, 47);
            this.formBuilderButton.TabIndex = 3;
            this.formBuilderButton.Text = "Form Builder";
            this.formBuilderButton.UseVisualStyleBackColor = true;
            // 
            // exitAppButton
            // 
            this.exitAppButton.Location = new System.Drawing.Point(587, 262);
            this.exitAppButton.Name = "exitAppButton";
            this.exitAppButton.Size = new System.Drawing.Size(90, 39);
            this.exitAppButton.TabIndex = 4;
            this.exitAppButton.Text = "Exit";
            this.exitAppButton.UseVisualStyleBackColor = true;
            this.exitAppButton.Click += new System.EventHandler(this.exitAppButton_Click);
            // 
            // MainScreen
            // 
            this.ClientSize = new System.Drawing.Size(689, 313);
            this.Controls.Add(this.exitAppButton);
            this.Controls.Add(this.formBuilderButton);
            this.Controls.Add(this.entityCreatorButton);
            this.Controls.Add(this.calcEngineButton);
            this.Controls.Add(this.label2);
            this.Name = "MainScreen";
            this.Text = "Disaster Recovery Solutions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button calcEngineButton;
        private Button entityCreatorButton;
        private Button formBuilderButton;
        private Button exitAppButton;
    }
}