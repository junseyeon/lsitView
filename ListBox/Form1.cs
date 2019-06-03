using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        String OrgStr = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.OrgStr = this.lbResult.Text;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CheckText();
        }

        private void CheckText()
        {
            if (this.txtList.Text != "")
            {
                this.lbView.Items.Add(this.txtList.Text);
                this.txtList.Text = "";         //입력 추가 되었을 때 txt비ㅔㄱ 만들기 
            }
            else
            {
                MessageBox.Show("항목을 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.txtList.Focus();
        }

        private void TxtList_KeyPress(object sender, KeyPressEventArgs e)           //keyPress누를 때 소리가 남 
        {
            if(e.KeyChar == 13) //enter
            {
                CheckText();
                e.Handled = true;   //처리했은깐 기본핸들러가 소리안내도 됨. (소리안나게됨)
            }
        }

        private void LbView_SelectedIndexChanged(object sender, EventArgs e)        //lbview중 선택되어있는거
        {
            this.lbResult.Text = this.OrgStr + this.lbView.Text;            //this.OrgStr 는 선택된거 텍스트 앞에 결과: 붙이려고 

        }
    }
}
