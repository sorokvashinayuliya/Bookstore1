using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace Bookstore1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            
            InitializeComponent();
        
            TreeNode root = new TreeNode("Книжный магазин");
            treeView1.Nodes.Add(root);
            TreeNode f1 = new TreeNode("Книги");
            TreeNode f2 = new TreeNode("Хобби и творчество");
            TreeNode f3 = new TreeNode("Игры и игрушки");
            root.Nodes.AddRange(new TreeNode[] {f1, f2, f3 });
            root.Expand();
            TreeNode h1 = new TreeNode("Название");
            TreeNode h2 = new TreeNode("Автор");
            TreeNode h3 = new TreeNode("Цена");
            TreeNode h4 = new TreeNode("Издательство");
            TreeNode h5 = new TreeNode("ID товара");
            f1.Nodes.Add(h1);
            f1.Nodes.Add(h2);
            f1.Nodes.Add(h3);
            f1.Nodes.Add(h4);
            f1.Nodes.Add(h5);
            TreeNode d1 = new TreeNode("Название");
            TreeNode d2 = new TreeNode("Бренд");
            TreeNode d3 = new TreeNode("Цена");
            TreeNode d4 = new TreeNode("Описание");
            TreeNode d5 = new TreeNode("ID товара");
            f2.Nodes.Add(d1);
            f2.Nodes.Add(d2);
            f2.Nodes.Add(d3);
            f2.Nodes.Add(d4);
            f2.Nodes.Add(d5);
            TreeNode p1 = new TreeNode("Название");
            TreeNode p2 = new TreeNode("Возрастные ограничения");
            TreeNode p3 = new TreeNode("Цена");
            TreeNode p4 = new TreeNode("Описание");
            TreeNode p5 = new TreeNode("ID товара");
            f3.Nodes.Add(p1);
            f3.Nodes.Add(p2);
            f3.Nodes.Add(p3);
            f3.Nodes.Add(p4);
            f3.Nodes.Add(p5);
        }

        private void load_Click(object sender, EventArgs e)
        {
            
        }
        
        

        private void picture_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void serialization_Click_1(object sender, EventArgs e)
        {
            var data = new ProgData()
            {

                Book=new List<Books> { },
                Game=new List<Games> { },
                Hobby=new List<Hobbies> { }
            };
            List<Book> books = new List<Book>();
            List<Hobby> hobbies = new List<Hobby>();
            
            var xmlSerializer = new XmlSerializer(typeof(ProgData));
            using (var fs = new FileStream("XmlBookstore.xml", FileMode.Create))
            {
                books = (List<Book>)xmlSerializer.Deserialize(fs);
                xmlSerializer.Serialize(fs, data);
                foreach (var book in books)
                {
                    dataGridView1.Rows.Add(book.Name, book.Id, book.Author, book.Price, book.Publisher);
                }
                foreach (var hobby in hobbies)
                {
                    dataGridView1.Rows.Add(hobby.Name, hobby.Id, hobby.Specification, hobby.Price, hobby.Company);
                }
            }



        }
        
        
    }
}
