using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coursework_WinForm_.Classes;
//using Coursework_WinForm_.model;

namespace Coursework_WinForm_
{
    public partial class AdminPanelForm : Form
    {
        private readonly ApplicationDbContext context;
        public AdminPanelForm()
        {
            InitializeComponent();
            context = new ApplicationDbContext();
            UpdateUsersGrid();
        }

        public void UpdateUsersGrid(UserSearchModel search = null)
        {
            dataGridViewUsers.Rows.Clear();
            var query = context.Users.Where(u => u.Deleted == false);

            if (search != null)
            {
                if (!string.IsNullOrEmpty(search.LastName))
                {
                    query = query.Where(u => u.LastName.Contains(search.LastName));
                }
                if (!string.IsNullOrEmpty(search.FirstName))
                {
                    query = query.Where(u => u.FirstName.Contains(search.FirstName));
                }
            }

            foreach (var item in query)
            {
                try
                {
                    //if (!item.Deleted)
                    //{
                    //var pathTmp = Path.Combine(Directory.GetCurrentDirectory(), "user_images", item.UserImage);
                    if (item.ToString() != "") 
                    {
                        DataGridViewColumn column = dataGridViewUsers.Columns[8];
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        ((DataGridViewImageColumn)dataGridViewUsers.Columns[8]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                        int k = 0;

                        using (MemoryStream ms = new MemoryStream(item.UserImage))
                        {
                            try
                            {
                                dataGridViewUsers.Rows.Add(new object[] { item.Id, item.FirstName, item.LastName, item.MobilePhoneNumber,
                        item.DateRegistered, item.LastLoginDate, item.Deleted, item.Email, Image.FromStream(ms)});
                                dataGridViewUsers.Rows[k++].Height = 50;
                                dataGridViewUsers.Rows[k].Height = 50;
                            }
                            catch (Exception)
                            {
                                dataGridViewUsers.Rows.Add(new object[] { item.Id, item.FirstName, item.LastName, item.MobilePhoneNumber,
                        item.DateRegistered, item.LastLoginDate, item.Email, item.Deleted});
                                dataGridViewUsers.Rows[k++].Height = 50;
                            }
                        }
                    }
                    else
                    {
                        dataGridViewUsers.Rows.Add(new object[] { item.Id, item.FirstName, item.LastName, item.MobilePhoneNumber,
                        item.DateRegistered, item.LastLoginDate, item.Email, item.Deleted});
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void BtnSearchLastName_Click(object sender, EventArgs e)
        {
            var lastName = txtLastName.Text;
            UserSearchModel search = new UserSearchModel();
            search.LastName = lastName;
            UpdateUsersGrid(search);
        }

        private void BtnSearchFirstName_Click(object sender, EventArgs e)
        {
            var firstName = txtFirstName.Text;
            UserSearchModel search = new UserSearchModel();
            search.FirstName = firstName;
            UpdateUsersGrid(search);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewUsers.SelectedRows[0];
            var id = int.Parse(row.Cells["UserId"].Value.ToString());
            var cat = context.Users.SingleOrDefault(c => c.Id == id);

            foreach (var item in context.UserRezalts)
            {
                if (item.UserID == cat.Id)
                {
                    context.UserRezalts.Remove(item);
                }
            }

            context.Users.Remove(cat);
            context.SaveChanges();

            UpdateUsersGrid();
        }
    }
}
