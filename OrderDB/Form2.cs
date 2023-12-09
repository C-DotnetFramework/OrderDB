using OrderDB.orderDB;
using OrderDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderDB.orderDB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrderDB
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            listBox3.Format += ListBox3_Format;
        }

        private void ListBox3_Format(object? sender, ListControlConvertEventArgs e)
        {
            var item = e.ListItem as POrderDetailForView;

            if (item != null)
            {
                e.Value = string.Format("{0} {1}개",
                    item.ProductName, item.Qty);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox1.DisplayMember = "name";
            listBox2.DisplayMember = "name";

            using (OrderDbContext db = new OrderDbContext())
            {
                foreach (var member in db.Members.ToList())
                {
                    listBox1.Items.Add(member);
                }

                foreach (var product in db.Products.ToList())
                {
                    listBox2.Items.Add(product);
                }
            }
        }

        private void cartButton_click(object sender, EventArgs e)
        {
            var selectedMember = listBox1.SelectedItem as Member;
            var selectedProduct = listBox2.SelectedItem as Product;
            var qty = int.Parse(textBox1.Text);

            bool updateFlag = false;
            foreach (var item in listBox3.Items)
            {
                if ((item as POrderDetailForView).ProductId == selectedProduct.Id)
                {
                    (item as POrderDetailForView).Qty += qty;
                    updateFlag = true;
                    break;
                }
            }

            if (updateFlag)
            {

            }
            else
            {
                listBox3.Items.Add(new POrderDetailForView()
                {
                    ProductId = selectedProduct.Id,
                    ProductName = selectedProduct.Name,
                    Qty = qty
                });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedMember = listBox1.SelectedItem as Member;

            using (OrderDbContext db = new OrderDbContext())
            {
                List<PorderDetail> list = new List<PorderDetail>();
                foreach (var item in listBox3.Items)
                {
                    list.Add(new PorderDetail()
                    {
                        ProductId = (item as POrderDetailForView).ProductId,
                        Qty = (item as POrderDetailForView).Qty
                    });

                }

                db.Porders.Add(new Porder()
                {
                    Created = DateTime.Now,
                    MemberId = selectedMember.Id,
                    PorderDetails = list
                });

                db.SaveChanges();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var selected = listBox3.SelectedItem as POrderDetailForView;

            if (selected != null)
                listBox3.Items.Remove(selected);
        }

        private void AllRemoveButton_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
        }
    }


}
