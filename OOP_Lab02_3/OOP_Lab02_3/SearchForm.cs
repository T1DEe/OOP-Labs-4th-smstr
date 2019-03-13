﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OOP_Lab02_3
{
    public enum SearchFormat
    {
        LINQ = 0,
        REGEX
    }

    public partial class SearchForm : Form
    {
        private SearchFormat searchFormat = SearchFormat.LINQ;

        public SearchForm()
        {
            InitializeComponent();
        }

        public SearchForm(Library library)
        {
            InitializeComponent();
            this.library = library;
        }

        private void inputBookTitle_TextChanged(object sender, EventArgs e)
        {
            if(searchFormat == SearchFormat.LINQ)
            {
                var search = library.GetBookCollection().Where(x => (x.Name == inputBookTitle.Text.ToString()) );
       
                listBoxSearchResult.Items.Clear();
                foreach (BookFile item in search)
                {
                    listBoxSearchResult.Items.Add("Название: " + item.Name + " | " + "Автор: " + item.Author);
                }
                listBoxSearchResult.Update();

                labelFound.Text = "Found: " + listBoxSearchResult.Items.Count.ToString();
            }
            else if(searchFormat == SearchFormat.REGEX)
            {

            }
        }

        private void btnYearSort_Click(object sender, EventArgs e)
        {
            listBoxSearchResult.Items.Clear();
            var sorted = library.GetBookCollection().OrderByDescending(u => u.Year);
            foreach (BookFile item in sorted)
            {
                listBoxSearchResult.Items.Add("Название: " + item.Name + " | " + "Автор: " + item.Author);
            }
            listBoxSearchResult.Update();
        }

        private void btnPageSort_Click(object sender, EventArgs e)
        {
            listBoxSearchResult.Items.Clear();
            var sorted = library.GetBookCollection().OrderByDescending(u => u.BookSize);
            foreach (BookFile item in sorted)
            {
                listBoxSearchResult.Items.Add("Название: " + item.Name + " | " + "Автор: " + item.Author);
            }
            listBoxSearchResult.Update();
        }

        private void btnUploadSort_Click(object sender, EventArgs e)
        {
            listBoxSearchResult.Items.Clear();
            var sorted = library.GetBookCollection().OrderByDescending(u => u.UploadDate);
            foreach (BookFile item in sorted)
            {
                listBoxSearchResult.Items.Add("Название: " + item.Name + " | " + "Автор: " + item.Author);
            }
            listBoxSearchResult.Update();
        }


        private void rbSearchFormat_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLinq.Checked)
            {
                searchFormat = SearchFormat.LINQ;
            }
            else if (rbRegex.Checked)
            {
                searchFormat = SearchFormat.REGEX;
            }
        }
    }
}