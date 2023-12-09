using Microsoft.EntityFrameworkCore;
using OrderDB;
using System.Windows.Forms;
using OrderDB.orderDB;

namespace OrderDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Format += ListBox1_Format;
            listBox2.Format += ListBox2_Format;
        }

        private void ListBox2_Format(object? sender, ListControlConvertEventArgs e)
        {
            var item = e.ListItem as POrderDetailForView;

            if (item != null)
            {
                e.Value = string.Format("{0} {1}°³",
                    item.ProductName, item.Qty);
            }
        }

        private void ListBox1_Format(object? sender, ListControlConvertEventArgs e)
        {
            var item = e.ListItem as POrderForView;

            if (item != null)
            {
                e.Value = string.Format("{0} {1}"
                    , item.MemberName,
                    item.Created);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        public void RefreshData()
        {
            listBox1.Items.Clear();

            using (var db = new orderDB.OrderDbContext())
            {
                var q = from p3 in db.Porders
                                    .Include(p => p.Member)
                                    .Include(p => p.PorderDetails)
                        select new POrderForView()
                        {
                            MemberName = p3.Member.Name,
                            Created = p3.Created,
                            POrderId = p3.Id,
                            Details = (from p1 in p3.PorderDetails
                                       join p2 in db.Products
                                       on p1.ProductId equals p2.Id
                                       select new POrderDetailForView()
                                       {
                                           ProductId = p1.ProductId,
                                           ProductName = p2.Name,
                                           Price = p2.Price,
                                           Qty = p1.Qty
                                       }).ToList()
                        };

                foreach (var item in q)
                    listBox1.Items.Add(item);

                /*
                foreach (var order in 
                    db.Porders
                    .Include(p => p.Member)
                    .Include(p => p.PorderDetails)
                    )
                {                  
                    
                    listBox1.Items.Add(new POrderForView()
                    {
                        MemberName = order.Member.Name,
                        Created = order.Created,
                        POrderId = order.Id,
                        Details = (from p1 in order.PorderDetails
                                  join p2 in db.Products
                                  on p1.ProductId equals p2.Id
                                  select new POrderDetailForView()
                                  {
                                      ProductId = p1.ProductId,
                                      ProductName = p2.Name,
                                      Qty = p1.Qty
                                  }).ToList()
                    });
                }
                */
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = listBox1.SelectedItem as POrderForView;

            int total = 0;
            if (selected != null)
            {
                listBox2.Items.Clear();

                foreach (var item in selected.Details)
                {
                    listBox2.Items.Add(item);
                    total += (item.Price * item.Qty);
                }
            }
            label4.Text = string.Format("{0} ¿ø", total);
        }
    }
}