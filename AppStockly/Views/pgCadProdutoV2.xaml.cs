using AppStockly.Models;
using AppStockly.ViewModels;

namespace AppStockly.Views
{
    public partial class pgCadProdutoV2 : ContentPage
    {
        public pgCadProdutoV2()
        {
            InitializeComponent();

            BindingContext = new CadProdutoViewModel();
        }


        public pgCadProdutoV2(Produto produto)
        {
            InitializeComponent();

            BindingContext = new CadProdutoViewModel(produto);
        }
    }
}