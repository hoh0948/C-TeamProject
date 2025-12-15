using System;
using System.Drawing;
using System.Windows.Forms;
namespace User_Kiosk_Program
{
    public partial class Form1 : Form
    {
        private Pop_Option_Drink popOptionDrink;
        public Form1()
        {
            InitializeComponent();

            /* form으로 팝업창
            //popOptionDrink = new Pop_Option_Drink();

            //popOptionDrink.Size = new Size(600, 850);

            //this.Controls.Add(popOptionDrink);

            //popOptionDrink.Visible = false;

            //popOptionDrink.Location = new Point(
            //(this.ClientSize.Width - popOptionDrink.Width) / 2,
            //(this.ClientSize.Height - popOptionDrink.Height) / 2);
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* form으로 팝업창
            // 팝업 창에 표시할 사용자 정의 컨트롤 인스턴스 생성
            Pop_Option_Drink popOptionDrink = new Pop_Option_Drink();

            // 사용자 정의 컨트롤을 담을 팝업 폼 생성
            PopUp popupForm = new PopUp(popOptionDrink);

            // 팝업 폼을 모달(modal) 형태로 띄웁니다.
            // 이 코드가 실행되면 팝업 창이 닫힐 때까지 Form1은 조작할 수 없습니다.
            popupForm.ShowDialog();

            // 팝업 창이 닫힌 후, 선택된 값을 가져와서 처리하는 로직을 추가할 수 있습니다.
            */
            /* 
            //popOptionDrink.Visible = true;
            //popOptionDrink.BringToFront();
            */

            
            //form1에서 사용자컨트롤 팝업창 생성
            // 1. 배경을 어둡게 할 오버레이 패널 생성
            Panel pnlOverlay = new Panel
            {
                Name = "pnlOverlay",
                Size = this.ClientSize,
                Location = new Point(0, 0),
                BackColor = Color.FromArgb(160, 0, 0, 0) // 반투명 검정
            };

            // 2. 팝업으로 사용할 사용자 정의 컨트롤 생성
            Pop_Option_Drink popupControl = new Pop_Option_Drink
            {
                Name = "popupControl",
                // 팝업 컨트롤을 폼의 정중앙에 배치
                Location = new Point(
                    (this.ClientSize.Width - 600) / 2,
                    (this.ClientSize.Height - 850) / 2)
            };

            // 4. 폼에 컨트롤들 추가
            this.Controls.Add(pnlOverlay);
            this.Controls.Add(popupControl);

            // 5. 컨트롤들을 맨 앞으로 가져와 다른 컨트롤에 가려지지 않게 함
            pnlOverlay.BringToFront();
            popupControl.BringToFront();
            
        }
    }
}
