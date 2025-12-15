namespace User_Kiosk_Program
{
    partial class Pop_Option_Drink
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            pb_Select_Image = new PictureBox();
            lb_Select_Name = new Label();
            lb_Select_Price = new Label();
            lb_Select_Info = new Label();
            panel1 = new Panel();
            pn__Option = new Panel();
            pn_Select_More = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            btn_Decaffein = new Button();
            btn_Sizeup = new Button();
            pn_Topping = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            lb_Option = new Label();
            btn_Unselected = new Button();
            btn_Hazelnut_syrup = new Button();
            btn_Vanilla_syrup = new Button();
            pn_Hot_Ice = new Panel();
            label1 = new Label();
            btn_Option_Ice = new Button();
            btn_Option_Hot = new Button();
            panel3 = new Panel();
            label3 = new Label();
            btn_Cancel = new Button();
            btn_Confirm = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_Select_Image).BeginInit();
            panel1.SuspendLayout();
            pn__Option.SuspendLayout();
            pn_Select_More.SuspendLayout();
            panel4.SuspendLayout();
            pn_Topping.SuspendLayout();
            panel2.SuspendLayout();
            pn_Hot_Ice.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pb_Select_Image
            // 
            pb_Select_Image.Image = Properties.Resources.다운로드;
            pb_Select_Image.Location = new Point(41, 48);
            pb_Select_Image.Margin = new Padding(4);
            pb_Select_Image.Name = "pb_Select_Image";
            pb_Select_Image.Size = new Size(156, 136);
            pb_Select_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Select_Image.TabIndex = 0;
            pb_Select_Image.TabStop = false;
            // 
            // lb_Select_Name
            // 
            lb_Select_Name.AutoSize = true;
            lb_Select_Name.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Select_Name.Location = new Point(230, 61);
            lb_Select_Name.Margin = new Padding(4, 0, 4, 0);
            lb_Select_Name.Name = "lb_Select_Name";
            lb_Select_Name.Size = new Size(125, 37);
            lb_Select_Name.TabIndex = 1;
            lb_Select_Name.Text = "카페라떼";
            // 
            // lb_Select_Price
            // 
            lb_Select_Price.AutoSize = true;
            lb_Select_Price.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Select_Price.Location = new Point(242, 132);
            lb_Select_Price.Margin = new Padding(4, 0, 4, 0);
            lb_Select_Price.Name = "lb_Select_Price";
            lb_Select_Price.Size = new Size(76, 28);
            lb_Select_Price.TabIndex = 2;
            lb_Select_Price.Text = "4800원";
            // 
            // lb_Select_Info
            // 
            lb_Select_Info.AutoSize = true;
            lb_Select_Info.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Select_Info.ForeColor = Color.Gray;
            lb_Select_Info.Location = new Point(41, 215);
            lb_Select_Info.Margin = new Padding(4, 0, 4, 0);
            lb_Select_Info.Name = "lb_Select_Info";
            lb_Select_Info.Size = new Size(365, 36);
            lb_Select_Info.TabIndex = 3;
            lb_Select_Info.Text = "베리에이션 커피의 일종으로, 에스프레소에 스팀 밀크를 올린 \r\n우유를 넣은 커피음료를 말한다.";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pn__Option);
            panel1.Location = new Point(0, 269);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 436);
            panel1.TabIndex = 4;
            // 
            // pn__Option
            // 
            pn__Option.AutoScroll = true;
            pn__Option.AutoScrollMargin = new Size(0, 500);
            pn__Option.AutoSize = true;
            pn__Option.BackColor = SystemColors.Control;
            pn__Option.Controls.Add(pn_Select_More);
            pn__Option.Controls.Add(pn_Topping);
            pn__Option.Controls.Add(pn_Hot_Ice);
            pn__Option.Dock = DockStyle.Fill;
            pn__Option.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            pn__Option.Location = new Point(0, 0);
            pn__Option.Margin = new Padding(4);
            pn__Option.Name = "pn__Option";
            pn__Option.Size = new Size(598, 434);
            pn__Option.TabIndex = 4;
            pn__Option.TabStop = true;
            // 
            // pn_Select_More
            // 
            pn_Select_More.Controls.Add(label4);
            pn_Select_More.Controls.Add(panel4);
            pn_Select_More.Controls.Add(btn_Decaffein);
            pn_Select_More.Controls.Add(btn_Sizeup);
            pn_Select_More.Location = new Point(40, 426);
            pn_Select_More.Name = "pn_Select_More";
            pn_Select_More.Size = new Size(471, 207);
            pn_Select_More.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 10);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 30);
            label4.TabIndex = 0;
            label4.Text = "추가선택";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientInactiveCaption;
            panel4.Controls.Add(label5);
            panel4.ForeColor = Color.FromArgb(255, 128, 0);
            panel4.Location = new Point(111, 16);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(105, 24);
            panel4.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DodgerBlue;
            label5.Location = new Point(4, 4);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 19);
            label5.TabIndex = 1;
            label5.Text = "선택 최대 2개";
            // 
            // btn_Decaffein
            // 
            btn_Decaffein.BackColor = Color.White;
            btn_Decaffein.Location = new Point(10, 64);
            btn_Decaffein.Margin = new Padding(4);
            btn_Decaffein.Name = "btn_Decaffein";
            btn_Decaffein.Size = new Size(131, 132);
            btn_Decaffein.TabIndex = 3;
            btn_Decaffein.Text = "디카페인\r\n변경\r\n\r\n+1000원";
            btn_Decaffein.TextAlign = ContentAlignment.MiddleLeft;
            btn_Decaffein.UseVisualStyleBackColor = false;
            // 
            // btn_Sizeup
            // 
            btn_Sizeup.BackColor = Color.White;
            btn_Sizeup.Location = new Point(149, 64);
            btn_Sizeup.Margin = new Padding(4);
            btn_Sizeup.Name = "btn_Sizeup";
            btn_Sizeup.Size = new Size(131, 132);
            btn_Sizeup.TabIndex = 3;
            btn_Sizeup.Text = "사이즈 업\r\n\r\n+1000원";
            btn_Sizeup.TextAlign = ContentAlignment.MiddleLeft;
            btn_Sizeup.UseVisualStyleBackColor = false;
            // 
            // pn_Topping
            // 
            pn_Topping.Controls.Add(panel2);
            pn_Topping.Controls.Add(lb_Option);
            pn_Topping.Controls.Add(btn_Unselected);
            pn_Topping.Controls.Add(btn_Hazelnut_syrup);
            pn_Topping.Controls.Add(btn_Vanilla_syrup);
            pn_Topping.Location = new Point(40, 220);
            pn_Topping.Name = "pn_Topping";
            pn_Topping.Size = new Size(471, 200);
            pn_Topping.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(label2);
            panel2.ForeColor = Color.FromArgb(255, 128, 0);
            panel2.Location = new Point(62, 15);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(105, 24);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(4, 4);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 19);
            label2.TabIndex = 1;
            label2.Text = "선택 최대 3개";
            // 
            // lb_Option
            // 
            lb_Option.AutoSize = true;
            lb_Option.Font = new Font("맑은 고딕", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Option.Location = new Point(7, 9);
            lb_Option.Margin = new Padding(4, 0, 4, 0);
            lb_Option.Name = "lb_Option";
            lb_Option.Size = new Size(57, 30);
            lb_Option.TabIndex = 0;
            lb_Option.Text = "토핑";
            // 
            // btn_Unselected
            // 
            btn_Unselected.BackColor = Color.White;
            btn_Unselected.Location = new Point(288, 63);
            btn_Unselected.Margin = new Padding(4);
            btn_Unselected.Name = "btn_Unselected";
            btn_Unselected.Size = new Size(131, 132);
            btn_Unselected.TabIndex = 3;
            btn_Unselected.TabStop = false;
            btn_Unselected.Text = "선택없음\r\n\r\n0원";
            btn_Unselected.TextAlign = ContentAlignment.MiddleLeft;
            btn_Unselected.UseVisualStyleBackColor = false;
            btn_Unselected.Click += btn_Unselected_Click;
            // 
            // btn_Hazelnut_syrup
            // 
            btn_Hazelnut_syrup.BackColor = Color.White;
            btn_Hazelnut_syrup.Location = new Point(149, 63);
            btn_Hazelnut_syrup.Margin = new Padding(4);
            btn_Hazelnut_syrup.Name = "btn_Hazelnut_syrup";
            btn_Hazelnut_syrup.Size = new Size(131, 132);
            btn_Hazelnut_syrup.TabIndex = 3;
            btn_Hazelnut_syrup.TabStop = false;
            btn_Hazelnut_syrup.Text = "헤이즐넛\r\n시럽추가\r\n0원";
            btn_Hazelnut_syrup.TextAlign = ContentAlignment.MiddleLeft;
            btn_Hazelnut_syrup.UseVisualStyleBackColor = false;
            btn_Hazelnut_syrup.Click += btn_Hazelnut_syrup_Click;
            // 
            // btn_Vanilla_syrup
            // 
            btn_Vanilla_syrup.BackColor = Color.White;
            btn_Vanilla_syrup.Location = new Point(10, 63);
            btn_Vanilla_syrup.Margin = new Padding(4);
            btn_Vanilla_syrup.Name = "btn_Vanilla_syrup";
            btn_Vanilla_syrup.Size = new Size(131, 132);
            btn_Vanilla_syrup.TabIndex = 3;
            btn_Vanilla_syrup.TabStop = false;
            btn_Vanilla_syrup.Text = "바닐라시럽\r\n추가\r\n0원";
            btn_Vanilla_syrup.TextAlign = ContentAlignment.MiddleLeft;
            btn_Vanilla_syrup.UseVisualStyleBackColor = false;
            btn_Vanilla_syrup.Click += btn_Vanilla_syrup_Click;
            // 
            // pn_Hot_Ice
            // 
            pn_Hot_Ice.Controls.Add(label1);
            pn_Hot_Ice.Controls.Add(btn_Option_Ice);
            pn_Hot_Ice.Controls.Add(btn_Option_Hot);
            pn_Hot_Ice.Controls.Add(panel3);
            pn_Hot_Ice.Location = new Point(40, 12);
            pn_Hot_Ice.Name = "pn_Hot_Ice";
            pn_Hot_Ice.Size = new Size(471, 202);
            pn_Hot_Ice.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 30);
            label1.TabIndex = 0;
            label1.Text = "HOT/ICE";
            // 
            // btn_Option_Ice
            // 
            btn_Option_Ice.BackColor = Color.White;
            btn_Option_Ice.Location = new Point(146, 63);
            btn_Option_Ice.Margin = new Padding(4);
            btn_Option_Ice.Name = "btn_Option_Ice";
            btn_Option_Ice.Size = new Size(131, 132);
            btn_Option_Ice.TabIndex = 3;
            btn_Option_Ice.TabStop = false;
            btn_Option_Ice.Text = "ICE\r\n\r\n+200원\r\n";
            btn_Option_Ice.TextAlign = ContentAlignment.MiddleLeft;
            btn_Option_Ice.UseVisualStyleBackColor = false;
            btn_Option_Ice.Click += btn_Option_Ice_Click;
            // 
            // btn_Option_Hot
            // 
            btn_Option_Hot.BackColor = Color.White;
            btn_Option_Hot.Location = new Point(7, 63);
            btn_Option_Hot.Margin = new Padding(4);
            btn_Option_Hot.Name = "btn_Option_Hot";
            btn_Option_Hot.Size = new Size(131, 132);
            btn_Option_Hot.TabIndex = 3;
            btn_Option_Hot.TabStop = false;
            btn_Option_Hot.Text = "HOT\r\n\r\n0원\r\n";
            btn_Option_Hot.TextAlign = ContentAlignment.MiddleLeft;
            btn_Option_Hot.UseVisualStyleBackColor = false;
            btn_Option_Hot.Click += btn_Option_Hot_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 224, 192);
            panel3.Controls.Add(label3);
            panel3.ForeColor = Color.FromArgb(255, 128, 0);
            panel3.Location = new Point(111, 15);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(82, 24);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(4, 4);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 19);
            label3.TabIndex = 1;
            label3.Text = "필수 선택";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(353, 741);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(164, 83);
            btn_Cancel.TabIndex = 5;
            btn_Cancel.Text = "취소하기";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Confirm
            // 
            btn_Confirm.Location = new Point(41, 741);
            btn_Confirm.Name = "btn_Confirm";
            btn_Confirm.Size = new Size(164, 83);
            btn_Confirm.TabIndex = 5;
            btn_Confirm.Text = "선택 완료";
            btn_Confirm.UseVisualStyleBackColor = true;
            btn_Confirm.Click += btn_Confirm_Click;
            // 
            // Pop_Option_Drink
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_Cancel);
            Controls.Add(panel1);
            Controls.Add(btn_Confirm);
            Controls.Add(lb_Select_Info);
            Controls.Add(lb_Select_Price);
            Controls.Add(lb_Select_Name);
            Controls.Add(pb_Select_Image);
            Margin = new Padding(4);
            Name = "Pop_Option_Drink";
            Size = new Size(600, 850);
            ((System.ComponentModel.ISupportInitialize)pb_Select_Image).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pn__Option.ResumeLayout(false);
            pn_Select_More.ResumeLayout(false);
            pn_Select_More.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            pn_Topping.ResumeLayout(false);
            pn_Topping.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pn_Hot_Ice.ResumeLayout(false);
            pn_Hot_Ice.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_Select_Image;
        private Label lb_Select_Name;
        private Label lb_Select_Price;
        private Label lb_Select_Info;
        private Panel panel1;
        private Panel pn__Option;
        private Label label2;
        private Label lb_Option;
        private Button btn_Vanilla_syrup;
        private Panel panel2;
        private Button btn_Option_Ice;
        private Button btn_Hazelnut_syrup;
        private Button btn_Option_Hot;
        private Panel panel3;
        private Label label3;
        private Label label1;
        private Button button5;
        private Button btn_Sizeup;
        private Button btn_Unselected;
        private Button btn_Decaffein;
        private Panel panel4;
        private Label label5;
        private Label label4;
        private Button btn_Cancel;
        private Button btn_Confirm;
        private Panel pn_Hot_Ice;
        private Panel pn_Topping;
        private Panel pn_Select_More;
    }
}
