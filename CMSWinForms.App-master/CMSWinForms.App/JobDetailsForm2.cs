using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinForms.App
{
    public partial class JobDetailsForm2 : Form
    {
        public JobDetailsForm2()
        {
            InitializeComponent();
        }

        private void tblJobDetailBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblJobDetailBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cMSDBDataSet);

        }

        private void JobDetailsForm2_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“cMSDBDataSet.tblJobDetail”中。您可以根据需要移动或移除它。
            this.tblJobDetailTableAdapter.Fill(this.cMSDBDataSet.tblJobDetail);

        }
    }
}
