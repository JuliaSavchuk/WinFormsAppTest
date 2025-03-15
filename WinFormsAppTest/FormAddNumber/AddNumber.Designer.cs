namespace WinFormsAppTest.FormAddNumber
{
    partial class AddNumber
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button_Result = new Button();
            label_result = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // button_Result
            // 
            button_Result.Location = new Point(146, 186);
            button_Result.Name = "button_Result";
            button_Result.Size = new Size(117, 39);
            button_Result.TabIndex = 2;
            button_Result.Text = "Result";
            button_Result.UseVisualStyleBackColor = true;
            button_Result.Click += button_Result_Click;
            // 
            // label_result
            // 
            label_result.AutoSize = true;
            label_result.Location = new Point(178, 276);
            label_result.Name = "label_result";
            label_result.Size = new Size(0, 20);
            label_result.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 44);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Num1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 109);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 5;
            label3.Text = "Num2";
            // 
            // AddNumber
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 337);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label_result);
            Controls.Add(button_Result);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "AddNumber";
            Text = "AddNumber";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button_Result;
        private Label label_result;
        private Label label2;
        private Label label3;
    }
}