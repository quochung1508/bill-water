namespace Bill_Water
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            lvBills = new ListView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            bntCalculate = new Button();
            bntAdd = new Button();
            btnUpdate = new Button();
            btnExit = new Button();
            tbName = new TextBox();
            tbLast = new TextBox();
            tbThis = new TextBox();
            cbbType = new ComboBox();
            label8 = new Label();
            tbPrice = new TextBox();
            tbBill = new TextBox();
            tbTotal = new TextBox();
            tbConsumed = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // lvBills
            // 
            lvBills.FullRowSelect = true;
            lvBills.Location = new Point(-1, 416);
            lvBills.Name = "lvBills";
            lvBills.Size = new Size(1198, 232);
            lvBills.TabIndex = 0;
            lvBills.UseCompatibleStateImageBehavior = false;
            lvBills.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(500, 9);
            label1.Name = "label1";
            label1.Size = new Size(231, 50);
            label1.TabIndex = 1;
            label1.Text = "WATER BILL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 220);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 2;
            label2.Text = "This Month";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 140);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 3;
            label3.Text = "Customer Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 97);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 4;
            label4.Text = "Customer Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(170, 187);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 5;
            label5.Text = "Last Month";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(761, 94);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 6;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(905, 94);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 7;
            label7.Text = "Bill + ENV";
            // 
            // bntCalculate
            // 
            bntCalculate.Location = new Point(299, 348);
            bntCalculate.Name = "bntCalculate";
            bntCalculate.Size = new Size(94, 29);
            bntCalculate.TabIndex = 4;
            bntCalculate.Text = "Calculate";
            bntCalculate.UseVisualStyleBackColor = true;
            bntCalculate.Click += bntCalculate_Click;
            // 
            // bntAdd
            // 
            bntAdd.Location = new Point(480, 348);
            bntAdd.Name = "bntAdd";
            bntAdd.Size = new Size(94, 29);
            bntAdd.TabIndex = 5;
            bntAdd.Text = "Add";
            bntAdd.UseVisualStyleBackColor = true;
            bntAdd.Click += bntAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(667, 348);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(839, 348);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(279, 94);
            tbName.Name = "tbName";
            tbName.Size = new Size(151, 27);
            tbName.TabIndex = 0;
            tbName.TextChanged += textBox1_TextChanged;
            // 
            // tbLast
            // 
            tbLast.Location = new Point(279, 184);
            tbLast.Name = "tbLast";
            tbLast.Size = new Size(151, 27);
            tbLast.TabIndex = 2;
            // 
            // tbThis
            // 
            tbThis.Location = new Point(279, 217);
            tbThis.Name = "tbThis";
            tbThis.Size = new Size(151, 27);
            tbThis.TabIndex = 3;
            // 
            // cbbType
            // 
            cbbType.FormattingEnabled = true;
            cbbType.Items.AddRange(new object[] { "House hold customer", "Adminnistrative agencies, public services", "Production unit", "Business services" });
            cbbType.Location = new Point(279, 137);
            cbbType.Name = "cbbType";
            cbbType.Size = new Size(151, 28);
            cbbType.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1048, 94);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 15;
            label8.Text = "Total Bill + VAT";
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(716, 137);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(139, 27);
            tbPrice.TabIndex = 16;
            // 
            // tbBill
            // 
            tbBill.Location = new Point(876, 137);
            tbBill.Name = "tbBill";
            tbBill.Size = new Size(138, 27);
            tbBill.TabIndex = 17;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(1034, 137);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(138, 27);
            tbTotal.TabIndex = 18;
            // 
            // tbConsumed
            // 
            tbConsumed.Location = new Point(279, 252);
            tbConsumed.Name = "tbConsumed";
            tbConsumed.Size = new Size(151, 27);
            tbConsumed.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(132, 255);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 19;
            label9.Text = "Water Consumed";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1197, 645);
            Controls.Add(tbConsumed);
            Controls.Add(label9);
            Controls.Add(tbTotal);
            Controls.Add(tbBill);
            Controls.Add(tbPrice);
            Controls.Add(label8);
            Controls.Add(cbbType);
            Controls.Add(tbThis);
            Controls.Add(tbLast);
            Controls.Add(tbName);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(bntAdd);
            Controls.Add(bntCalculate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lvBills);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvBills;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button bntCalculate;
        private Button bntAdd;
        private Button btnUpdate;
        private Button btnExit;
        private TextBox tbName;
        private TextBox tbLast;
        private TextBox tbThis;
        private ComboBox cbbType;
        private Label label8;
        private TextBox tbPrice;
        private TextBox tbBill;
        private TextBox tbTotal;
        private TextBox tbConsumed;
        private Label label9;
    }
}