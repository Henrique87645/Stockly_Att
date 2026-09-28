using AppStockly.Models;
using System.Collections.ObjectModel;

namespace AppStockly.Singleton
{
    public class ProdutoSingleton
    {
        private static ProdutoSingleton instancia;

        public ObservableCollection<Produto> Produtos { get; set; }

        private ProdutoSingleton()
        {
            Produtos = new ObservableCollection<Produto>();
        }

        public static ProdutoSingleton Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ProdutoSingleton();
                }

                return instancia;
            }
        }
    }
}