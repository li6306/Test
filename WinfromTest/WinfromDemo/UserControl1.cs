using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinfromDemo
{
    public partial class UserControl1: UserControl
    {
        int actiontype = 0;  //运算符
        public UserControl1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 数字按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVaL_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (actiontype > 0)
            {
                if (!string.IsNullOrEmpty(tNum2.Text.Trim()))
                {
                    if (btn.Text == ".")
                    {
                        if (tNum2.Text.IndexOf('.') < 0)
                            tNum2.Text += btn.Text.Trim();
                        return;
                    }
                    tNum2.Text += btn.Text.Trim();
                }
                else
                {
                    tNum2.Text = btn.Text.Trim();
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(tNum1.Text.Trim()))
                {
                    if (btn.Text == ".")
                    {
                        if (tNum1.Text.IndexOf('.') < 0)
                            tNum1.Text += btn.Text;
                        return;
                    }
                    tNum1.Text += btn.Text;
                }
                else
                {
                    tNum1.Text = btn.Text;
                }
            }
        }

        /// <summary>
        /// 绑定事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserControl1_Load(object sender, EventArgs e)
        {
            num0.Click+= new EventHandler(btnVaL_Click);
            num1.Click += new EventHandler(btnVaL_Click);
            num2.Click += new EventHandler(btnVaL_Click);
            num3.Click += new EventHandler(btnVaL_Click);
            num4.Click += new EventHandler(btnVaL_Click);
            num5.Click += new EventHandler(btnVaL_Click);
            num6.Click += new EventHandler(btnVaL_Click);
            num7.Click += new EventHandler(btnVaL_Click);
            num8.Click += new EventHandler(btnVaL_Click);
            num9.Click += new EventHandler(btnVaL_Click);
            decimalPoint.Click+= new EventHandler(btnVaL_Click);
        }

        //加运算
        private void Btn_add_Click(object sender, EventArgs e)
        {
            actiontype = 1;
            lblOperator.Text = btn_add.Text;
            if (!string.IsNullOrEmpty(tNum2.Text.Trim()))
            {
                tResult.Text = (decimal.Parse(tNum1.Text.Trim()) + decimal.Parse(tNum2.Text.Trim())).ToString();
            }
        }

        //减运算
        private void Btn_less_Click(object sender, EventArgs e)
        {
            actiontype = 2;
            lblOperator.Text = btn_less.Text;
            if (!string.IsNullOrEmpty(tNum2.Text.Trim()))
            {
                tResult.Text = (decimal.Parse(tNum1.Text.Trim()) - decimal.Parse(tNum2.Text.Trim())).ToString();
            }
        }

        //乘运算
        private void Btn_multiply_Click(object sender, EventArgs e)
        {
            actiontype = 3;
            lblOperator.Text = btn_multiply.Text;
            if (!string.IsNullOrEmpty(tNum2.Text.Trim()))
            {
                tResult.Text = (decimal.Parse(tNum1.Text.Trim()) * decimal.Parse(tNum2.Text.Trim())).ToString();
            }
        }

        //除运算
        private void Btn_except_Click(object sender, EventArgs e)
        {
            actiontype = 4;
            lblOperator.Text = btn_except.Text;
            if (!string.IsNullOrEmpty(tNum2.Text.Trim()))
            {
                tResult.Text = (decimal.Parse(tNum1.Text.Trim()) / decimal.Parse(tNum2.Text.Trim())).ToString();
            }
        }

        //按钮事件
        private void Calculation_Click(object sender, EventArgs e)
        {
            switch (actiontype) {
                case 1:
                    tResult.Text = (decimal.Parse(tNum1.Text.Trim()) + decimal.Parse(tNum2.Text.Trim())).ToString();
                    break;
                case 2:
                    tResult.Text = (decimal.Parse(tNum1.Text.Trim()) - decimal.Parse(tNum2.Text.Trim())).ToString();
                    break;
                case 3:
                    tResult.Text = (decimal.Parse(tNum1.Text.Trim()) * decimal.Parse(tNum2.Text.Trim())).ToString();
                    break;
                case 4:
                    tResult.Text = (decimal.Parse(tNum1.Text.Trim()) / decimal.Parse(tNum2.Text.Trim())).ToString();
                    break;
            }
            actiontype = 0;
            tNum1.Text = "";
            tNum2.Text = "";
        }
    }
}
