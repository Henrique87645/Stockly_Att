using AppStockly.Models;
using AppStockly.Singleton;
using AppStockly.Views;
using System.Collections.ObjectModel;

namespace AppStockly.ViewModels
{
    public class ListaProdutoViewModel : BaseNotifyViewModel
    {
        public ObservableCollection<Produto> Produtos
        {
            get
            {
                return ProdutoSingleton.Instancia.Produtos;
            }
        }


        public Command ExcluirCommand
        {
            get
            {
                return new Command<Produto>(async (produto) =>
                {
                    bool confirmar = await Application.Current.MainPage.DisplayAlert(
                        "Excluir produto",
                        "Deseja realmente excluir este produto?",
                        "Sim",
                        "Não");

                    if (confirmar)
                    {
                        ProdutoSingleton.Instancia.Produtos.Remove(produto);

                        await Application.Current.MainPage.DisplayAlert(
                            "Sucesso",
                            "Produto excluído com sucesso!",
                            "OK");
                    }
                });
            }
        }

        public Command EditarCommand
        {
            get
            {
                return new Command<Produto>(async (produto) =>
                {
                    await Application.Current.MainPage.Navigation.PushAsync(new pgCadProdutoV2(produto));
                });
            }
        }

        public Command VoltarCommand
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage = new NavigationPage(new pgPrincipal());
                });
            }
        }
    }
}