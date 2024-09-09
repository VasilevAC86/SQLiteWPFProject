using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLiteDEmo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbOutput.Text = DBWork.MakeDB();
        }

        private void btnAddCategory_Click(object sender, EventArgs e) // Метод добавляет данные, которые получает из класса
        {
            Category _category = new Category(tBInput.Text); // Создаём объект
            string insert_querry = _category.AddCategory();
            DBWork.AddData(insert_querry);
            tBInput.Text = string.Empty;
        }

        private void btnRefreshDG_Click(object sender, EventArgs e)
        {
            dGCategory.DataSource = DBWork.Refresh().Tables[0];
            dGCategory.Update();
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            string _query = string.Empty;
            DataTable dt = (DataTable)dGCategory.DataSource;
            DBWork.Save(dt, out _query);
            tBQuery.Text = _query;
        }
    }
}
