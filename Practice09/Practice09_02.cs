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
    public partial class Practice09_02 : Form
    {
        public Practice09_02()
        {
            InitializeComponent();
        }

        private void rdoExpenditure_CheckedChanged(object sender, EventArgs e)
        {
            cboCategory.Items.Clear();
            if(rdoExpenditure.Checked == true)
            {
                cboCategory.Items.Add("生活消费");
                cboCategory.Items.Add("固定资产");
                cboCategory.Items.Add("休闲娱乐");
                cboCategory.Items.Add("医疗药品");
                cboCategory.Items.Add("教育培训");
                cboCategory.Items.Add("其他支出");
            }
            else
            {
                cboCategory.Items.Add("工作收入");
                cboCategory.Items.Add("投资收益");
                cboCategory.Items.Add("其他收入");
            }
            cboCategory.SelectedIndex = 0;  // 列表中初始选择第一项
        }

        private void Practice09_02_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            rtxtRemarks.Clear();
            rtxtRemarks.AppendText("要添加的信息为: \n");
            rtxtRemarks.AppendText(cboCategory.SelectedItem.ToString());
            rtxtRemarks.AppendText("-");
            rtxtRemarks.AppendText(lstItem.SelectedItem.ToString());
            rtxtRemarks.AppendText("\n日期: ");
            rtxtRemarks.AppendText(dtpDate.Value.ToString());
            rtxtRemarks.AppendText("\n说明: ");
            rtxtRemarks.AppendText(txtExplain.Text);
            rtxtRemarks.AppendText("\n收支人: ");
            if (chkOwn.Checked) { rtxtRemarks.AppendText(chkOwn.Text); }
            if (chkFamily.Checked) { rtxtRemarks.AppendText("、" + chkFamily.Text); }
            if (chkRelative.Checked) { rtxtRemarks.AppendText("、" + chkRelative.Text); }
            if (chkFriend.Checked) { rtxtRemarks.AppendText("、" + chkFriend.Text); }
            if (chkColleague.Checked) { rtxtRemarks.AppendText("、" + chkColleague.Text); }
            if (chkOther.Checked) { rtxtRemarks.AppendText("、" + chkOther.Text); }
            rtxtRemarks.AppendText("\n金额: ");
            rtxtRemarks.AppendText(numAmount.Value.ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string t = cboCategory.SelectedItem.ToString();
            lstItem.Items.Clear();
            switch (t)
            {
                case "生活消费":
                    lstItem.Items.Add("餐饮");
                    lstItem.Items.Add("生活用品");
                    lstItem.Items.Add("水电费");
                    lstItem.Items.Add("交通费");
                    break;
                case "固定资产":
                    lstItem.Items.Add("房贷");
                    lstItem.Items.Add("车贷");
                    break;
                case "休闲娱乐":
                    lstItem.Items.Add("旅游");
                    lstItem.Items.Add("奢侈品");
                    lstItem.Items.Add("电子产品");
                    break;
                case "医疗产品":
                    lstItem.Items.Add("药品");
                    lstItem.Items.Add("住院");
                    break;
                case "教育培训":
                    lstItem.Items.Add("学费");
                    lstItem.Items.Add("生活费");
                    break;
                case "工作收入":
                    lstItem.Items.Add("工资");
                    lstItem.Items.Add("奖金");
                    break;
                case "投资收益":
                    lstItem.Items.Add("利息");
                    lstItem.Items.Add("股票");
                    lstItem.Items.Add("基金");
                    break;
                default:
                    lstItem.Items.Add("无");
                    break;
            }
            lstItem.SelectedIndex = 0;  // 默认选中第一项
        }
    }
}
