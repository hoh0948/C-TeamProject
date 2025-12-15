using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Kiosk_Program
{
    public partial class PopUp : Form
    {
        
        public PopUp(UserControl customControl)
        {
            InitializeComponent();

            // 팝업 폼의 속성 설정
            this.ClientSize = customControl.Size; // 사용자 정의 컨트롤의 크기에 맞춰 폼 크기 설정
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // 크기 조절 불가한 대화 상자 스타일
            this.StartPosition = FormStartPosition.CenterParent; // 부모 폼(Form1) 중앙에 위치
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // 전달받은 사용자 정의 컨트롤을 폼에 추가
            this.Controls.Add(customControl);
        }
    }
}
