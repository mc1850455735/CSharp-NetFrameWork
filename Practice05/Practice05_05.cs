using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCourse_NetFrameWork
{
    public partial class Practice05_05 : Form
    {
        Account a;
        public Practice05_05()
        {
            InitializeComponent();
        }

        private void Practice05_05_Load(object sender, EventArgs e)
        {

        }

        private void btnCommon_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            double balance = double.Parse(txtBalance.Text);
            try { a = new Account(name, balance); }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }
            lblShow.Text = "普通账户成功创建";
        }

        private void btnVIP_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            double balance = double.Parse(txtBalance.Text);
            try { a = new VipAccount(name, balance); }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }
            lblShow.Text = "VIP账户成功创建";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try { a.Withdraw(double.Parse(txtBalance.Text)); }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }
            lblShow.Text = string.Format("{0}还剩余{1}, 取出了{2}", a.creditNo, a.balance, txtBalance.Text);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                a.Deposit(double.Parse(txtBalance.Text));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }
            lblShow.Text = string.Format("{0}还剩余{1}, 取出了{2}", a.creditNo, a.balance, txtBalance.Text);
        }
    }

    class Account
    {
        protected string CreditNo;
        protected double Balance;

        public string creditNo => CreditNo;
        public double balance => Balance;

        public Account(string creditNo, double balance)
        {
            if (balance < 100000 || balance > 500000) { throw new OverflowException("参数不符合数据范围"); }
            CreditNo = creditNo;
            Balance = balance;
        }

        // 在子类中不检查合法性的创建父类对象
        protected Account(string creditNo, double balance, int a) {
            CreditNo = creditNo;
            Balance = balance;
        }

        // 存款
        public virtual void Withdraw(double n)
        {
            if (Balance + n > 500000)
            {
                throw new OverflowException("数值范围不正确");
            }

            Balance += n;
        }

        public virtual void Deposit(double n)
        {
            if (Balance - n < 0)
            {
                throw new OverflowException("数值范围不正确");
            }

            Balance -= n;
        }
    }

    class VipAccount : Account
    {
        public VipAccount(string creditNo, double balance) : base(creditNo, balance, 0) {
            if (balance < 500000 || balance > 1000000) { throw new OverflowException("参数不符合数据范围"); }
            CreditNo = creditNo;
            Balance = balance;
        }

        public override void Withdraw(double n)
        {
            if (Balance + n > 1000000)
            {
                throw new OverflowException("数值范围不正确");
            }

            Balance += n;
        }

        public override void Deposit(double n)
        {
            if (Balance - n < -1000)
            {
                throw new OverflowException("数值范围不正确");
            }

            Balance -= n;
        }
    }
}
