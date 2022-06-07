﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using WPF_App.Productstuff;
namespace WPF_App
{
    /// <summary>
    /// Interaction logic for ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public ProductPage()
        {
            InitializeComponent();
        }

        public void addItem_Click(object sender, RoutedEventArgs e)
        {
            NewProductWindow newProduct = new NewProductWindow();
            newProduct.Show();
        }

        private void deleteItem_Click(object sender, RoutedEventArgs e)
        {
            DeleteItemWindow deleteItemWindow = new();
            deleteItemWindow.Show();
        }

        private void showItems_Click(object sender, RoutedEventArgs e)
        {
            AllProductsWindow allProductsWindow = new();
            allProductsWindow.Show();
        }

        private void editItem_Click(object sender, RoutedEventArgs e)
        {
            EditItemWindow editItemWindow = new();
            editItemWindow.Show();
        }
    }
}
