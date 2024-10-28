namespace AdapterPatern
{
    partial class MenuForm
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
            CS01Button = new Button();
            CS02Button = new Button();
            VB01Button = new Button();
            VB02Button = new Button();
            SuspendLayout();
            // 
            // CS01Button
            // 
            CS01Button.Location = new Point(145, 74);
            CS01Button.Name = "CS01Button";
            CS01Button.Size = new Size(164, 44);
            CS01Button.TabIndex = 0;
            CS01Button.Text = "CS01";
            CS01Button.UseVisualStyleBackColor = true;
            CS01Button.Click += CS01Button_Click;
            // 
            // CS02Button
            // 
            CS02Button.Location = new Point(145, 124);
            CS02Button.Name = "CS02Button";
            CS02Button.Size = new Size(164, 44);
            CS02Button.TabIndex = 1;
            CS02Button.Text = "CS02";
            CS02Button.UseVisualStyleBackColor = true;
            CS02Button.Click += CS02Button_Click;
            // 
            // VB01Button
            // 
            VB01Button.Location = new Point(145, 174);
            VB01Button.Name = "VB01Button";
            VB01Button.Size = new Size(164, 44);
            VB01Button.TabIndex = 2;
            VB01Button.Text = "VB01";
            VB01Button.UseVisualStyleBackColor = true;
            VB01Button.Click += VB01Button_Click;
            // 
            // VB02Button
            // 
            VB02Button.Location = new Point(145, 224);
            VB02Button.Name = "VB02Button";
            VB02Button.Size = new Size(164, 44);
            VB02Button.TabIndex = 3;
            VB02Button.Text = "VB02";
            VB02Button.UseVisualStyleBackColor = true;
            VB02Button.Click += VB02Button_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 296);
            Controls.Add(VB02Button);
            Controls.Add(VB01Button);
            Controls.Add(CS02Button);
            Controls.Add(CS01Button);
            Name = "MenuForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button CS01Button;
        private Button CS02Button;
        private Button VB01Button;
        private Button VB02Button;
    }
}
