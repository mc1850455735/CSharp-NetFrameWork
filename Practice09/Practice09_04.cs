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
    public partial class Practice09_04 : Form
    {
        public Practice09_04()
        {
            InitializeComponent();
        }

        private void rdoExpenditure_CheckedChanged(object sender, EventArgs e)
        {
            cboCategory.Items.Clear();
            cboCategory.Items.Add("一级大类");
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
            cboCategory.SelectedIndex = 0;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Trim() == "" || cboCategory.Text == "")
            {
                MessageBox.Show("请填写完整信息!", "信息不完整",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tbControl.SelectedTab = tpgAcceptInfo;
            }
        }

        private void tbControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tbControl.SelectedIndex == 1)
            {
                if (txtName.Text.Trim() == "" || cboCategory.Text == "")
                {
                    MessageBox.Show("请填写完整信息!", "信息不完整",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbControl.SelectedTab = tpgProjectInfo;
                }               
                else
                {
                    rtxtShow.Clear();
                    rtxtShow.AppendText("要添加的收支项目为: ");
                    rtxtShow.AppendText(txtName.Text);
                    rtxtShow.AppendText("\n所属类别:" + cboCategory.SelectedItem.ToString());
                    if(rdoExpenditure.Checked == true)
                        rtxtShow.AppendText("\n支出类型");
                    else
                        rtxtShow.AppendText("\n收入类型");
                }
            }
        }
    }
}
