namespace PigLatin
{
    partial class Pig_Latin_Translator
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
            translate_Button = new Button();
            clear_Button = new Button();
            Input = new TextBox();
            Output = new TextBox();
            SuspendLayout();
            // 
            // translate_Button
            // 
            translate_Button.Location = new Point(245, 508);
            translate_Button.Name = "translate_Button";
            translate_Button.Size = new Size(341, 129);
            translate_Button.TabIndex = 0;
            translate_Button.Text = "Translate";
            translate_Button.UseVisualStyleBackColor = true;
            translate_Button.Click += translate_Button_Click;
            // 
            // clear_Button
            // 
            clear_Button.Location = new Point(853, 508);
            clear_Button.Name = "clear_Button";
            clear_Button.Size = new Size(341, 129);
            clear_Button.TabIndex = 1;
            clear_Button.Text = "Clear";
            clear_Button.UseVisualStyleBackColor = true;
            clear_Button.Click += clear_Button_Click;
            // 
            // Input
            // 
            Input.Location = new Point(371, 184);
            Input.Multiline = true;
            Input.Name = "Input";
            Input.Size = new Size(742, 118);
            Input.TabIndex = 2;
            // 
            // Output
            // 
            Output.Location = new Point(371, 327);
            Output.Multiline = true;
            Output.Name = "Output";
            Output.Size = new Size(742, 118);
            Output.TabIndex = 3;
            // 
            // Pig_Latin_Translator
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1485, 808);
            Controls.Add(Output);
            Controls.Add(Input);
            Controls.Add(clear_Button);
            Controls.Add(translate_Button);
            Name = "Pig_Latin_Translator";
            Text = "Pig Latin Translator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button translate_Button;
        private Button clear_Button;
        private TextBox Input;
        private TextBox Output;
    }
}