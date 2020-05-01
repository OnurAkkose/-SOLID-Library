using LibraryBusiness.Abstract;
using LibraryBusiness.DependencyResolvers.Ninject;
using LibraryEntities.Concrate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _bookService = InstanceFactory.GetInstance<IBookService>();
            _authorService = InstanceFactory.GetInstance<IAuthorService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadBooks();
            loadAuthors();
           
        }
        private IBookService _bookService;
        private IAuthorService _authorService;


        private void loadBooks()
        {
            grdbooks.DataSource = _bookService.GetAll();

        }
        private void loadAuthors()
        {
            grdauthors.DataSource = _authorService.GetAll();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            _bookService.Add(new Book
            {
                BookName = txtnewname.Text,
                AuthorName = txtnewauthor.Text
            });
            MessageBox.Show("Added!");
            loadBooks();
        }

       

        private void btnNewauthor_Click(object sender, EventArgs e)
        {
            _authorService.Add(new Author
            {
                AuthorName = txtAname.Text,
                AuthorSurname = txtAsurname.Text

            }) ;
            MessageBox.Show("Added!");
            loadAuthors();
        }

        private void btndelBook_Click(object sender, EventArgs e)
        {
            _bookService.Delete(new Book
            {
                BookName = txtDbook.Text,
                AuthorName = txtdelauthor.Text
            }) ;
            MessageBox.Show("Added!");
            loadBooks();
        }

        private void bnAdelete_Click(object sender, EventArgs e)
        {
            _authorService.Delete(new Author
            {
                AuthorName = txtAname.Text,
                AuthorSurname = txtAsurname.Text

            });
            MessageBox.Show("Added!");
            loadAuthors();
        }

       
    }
}
