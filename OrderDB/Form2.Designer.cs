namespace OrderDB
{
    partial class Form2
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
            label1 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label2 = new Label();
            textBox1 = new TextBox();
            cartButton = new Button();
            listBox3 = new ListBox();
            label3 = new Label();
            RemoveButton = new Button();
            AllRemoveButton = new Button();
            button2 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 40);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "회원 목록";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(57, 63);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 244);
            listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(213, 63);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 244);
            listBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 40);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 2;
            label2.Text = "제품";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(525, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 27);
            textBox1.TabIndex = 4;
            // 
            // cartButton
            // 
            cartButton.Location = new Point(681, 63);
            cartButton.Name = "cartButton";
            cartButton.Size = new Size(150, 29);
            cartButton.TabIndex = 5;
            cartButton.Text = "담기";
            cartButton.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Location = new Point(369, 63);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(150, 244);
            listBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 40);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 7;
            label3.Text = "주문 상세";
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(681, 109);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(150, 96);
            RemoveButton.TabIndex = 8;
            RemoveButton.Text = "선택한 제품 빼기";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // AllRemoveButton
            // 
            AllRemoveButton.Location = new Point(681, 211);
            AllRemoveButton.Name = "AllRemoveButton";
            AllRemoveButton.Size = new Size(150, 96);
            AllRemoveButton.TabIndex = 9;
            AllRemoveButton.Text = "모든 제품 빼기";
            AllRemoveButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(57, 313);
            button2.Name = "button2";
            button2.Size = new Size(774, 96);
            button2.TabIndex = 10;
            button2.Text = "위 주문 상세대로 주문 생성";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(525, 40);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 11;
            label4.Text = "수량";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 450);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(AllRemoveButton);
            Controls.Add(RemoveButton);
            Controls.Add(label3);
            Controls.Add(listBox3);
            Controls.Add(cartButton);
            Controls.Add(textBox1);
            Controls.Add(listBox2);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label2;
        private TextBox textBox1;
        private Button cartButton;
        private ListBox listBox3;
        private Label label3;
        private Button RemoveButton;
        private Button AllRemoveButton;
        private Button button2;
        private Label label4;
    }
}