using AppStockly.Models;
using AppStockly.Singleton;

namespace AppStockly.ViewModels
{
    public class CadProdutoViewModel : BaseNotifyViewModel
    {
        private Produto produtoEdicao;

        //Nome do Produto
        private string _produto; //BACKEND
        public string Produto  //FRONTEND
        {
            get { return _produto; }
            set
            {
                _produto = value;
                OnPropertyChanged();  //LEITURA do Front -> Produto e vou jogar para o meu backend -> _produto
            }
        }

        private string _mensagemValidacaoNomeProduto;
        public string MensagemValidacaoNomeProduto
        {
            get { return _mensagemValidacaoNomeProduto; }
            set
            {
                _mensagemValidacaoNomeProduto = value;
                OnPropertyChanged();
            }
        }

        private bool _exibirValidacaoNomeProduto;
        public bool ExibirValidacaoNomeProduto
        {
            get { return _exibirValidacaoNomeProduto; }
            set
            {
                _exibirValidacaoNomeProduto = value;
                OnPropertyChanged();
            }
        }

        //Nome do Produto
        private string _modelo; //BACKEND
        public string Modelo  //FRONTEND
        {
            get { return _modelo; }
            set
            {
                _modelo = value;
                OnPropertyChanged();  //LEITURA do Front -> Produto e vou jogar para o meu backend -> _produto
            }
        }

        private string _mensagemValidacaoModelo;
        public string MensagemValidacaoModelo
        {
            get { return _mensagemValidacaoModelo; }
            set
            {
                _mensagemValidacaoModelo = value;
                OnPropertyChanged();
            }
        }

        private bool _exibirMensagemValidacaoModelo;
        public bool ExibirMensagemValidacaoModelo
        {
            get { return _exibirMensagemValidacaoModelo; }
            set
            {
                _exibirMensagemValidacaoModelo = value;
                OnPropertyChanged();
            }
        }


        //Codigo do produto
        private string _Codigo;
        public string Codigo
        {
            get { return _Codigo; }
            set
            {
                _Codigo = value;
                OnPropertyChanged(nameof(Codigo));
            }
        }

        private string _mensagemValidacaoCodigo;
        public string MensagemValidacaoCodigo
        {
            get { return _mensagemValidacaoCodigo; }
            set
            {
                _mensagemValidacaoCodigo = value;
                OnPropertyChanged();
            }
        }

        private bool _exibirMensagemValidacaoCodigo;
        public bool ExibirMensagemValidacaoCodigo
        {
            get { return _exibirMensagemValidacaoCodigo; }
            set
            {
                _exibirMensagemValidacaoCodigo = value;
                OnPropertyChanged();
            }
        }


        //Fornecedores
        private string _Fornecedor;
        public string Fornecedor
        {
            get { return _Fornecedor; }
            set
            {
                _Fornecedor = value;
                OnPropertyChanged(nameof(Fornecedor));
            }
        }

        private string _mensagemValidacaoFornecedor;
        public string MensagemValidacaoFornecedor
        {
            get { return _mensagemValidacaoFornecedor; }
            set
            {
                _mensagemValidacaoFornecedor = value;
                OnPropertyChanged();
            }
        }

        private bool _exibirMensagemValidacaoFornecedor;
        public bool ExibirMensagemValidacaoFornecedor
        {
            get { return _exibirMensagemValidacaoFornecedor; }
            set
            {
                _exibirMensagemValidacaoFornecedor = value;
                OnPropertyChanged();
            }
        }


        //Quantidades
        private string _Quantidade;
        public string Quantidade
        {
            get { return _Quantidade; }
            set
            {
                _Quantidade = value;
                OnPropertyChanged(nameof(Quantidade));
            }
        }

        private string _mensagemValidacaoQuantidade;
        public string MensagemValidacaoQuantidade
        {
            get { return _mensagemValidacaoQuantidade; }
            set
            {
                _mensagemValidacaoQuantidade = value;
                OnPropertyChanged();
            }
        }

        private bool _exibirMensagemValidacaoQuantidade;
        public bool ExibirMensagemValidacaoQuantidade
        {
            get { return _exibirMensagemValidacaoQuantidade; }
            set
            {
                _exibirMensagemValidacaoQuantidade = value;
                OnPropertyChanged();
            }
        }


        //Preço de Compra
        private string _PrecoCompra;
        public string PrecoCompra
        {
            get { return _PrecoCompra; }
            set
            {
                _PrecoCompra = value;
                OnPropertyChanged(nameof(PrecoCompra));
            }
        }

        private string _mensagemValidacaoPrecoCompra;
        public string MensagemValidacaoPrecoCompra
        {
            get { return _mensagemValidacaoPrecoCompra; }
            set
            {
                _mensagemValidacaoPrecoCompra = value;
                OnPropertyChanged();
            }
        }

        private bool _exibirMensagemValidacaoPrecoCompra;
        public bool ExibirMensagemValidacaoPrecoCompra
        {
            get { return _exibirMensagemValidacaoPrecoCompra; }
            set
            {
                _exibirMensagemValidacaoPrecoCompra = value;
                OnPropertyChanged();
            }
        }


        //Preço de vendas
        private string _PrecoVenda;
        public string PrecoVenda
        {
            get { return _PrecoVenda; }
            set
            {
                _PrecoVenda = value;
                OnPropertyChanged(nameof(PrecoVenda));
            }
        }

        private string _mensagemValidacaoPrecoVenda;
        public string MensagemValidacaoPrecoVenda
        {
            get { return _mensagemValidacaoPrecoVenda; }
            set
            {
                _mensagemValidacaoPrecoVenda = value;
                OnPropertyChanged();
            }
        }

        private bool _exibirMensagemValidacaoPrecoVenda;
        public bool ExibirMensagemValidacaoPrecoVenda
        {
            get { return _exibirMensagemValidacaoPrecoVenda; }
            set
            {
                _exibirMensagemValidacaoPrecoVenda = value;
                OnPropertyChanged();
            }
        }


        //Estoque Minimo
        private string _estoqueMinimo;
        public string EstoqueMinimo
        {
            get { return _estoqueMinimo; }
            set
            {
                _estoqueMinimo = value;
                OnPropertyChanged(nameof(EstoqueMinimo));
            }
        }

        private string _mensagemValidacaoEstoqueMinimo;
        public string MensagemValidacaoEstoqueMinimo
        {
            get { return _mensagemValidacaoEstoqueMinimo; }
            set
            {
                _mensagemValidacaoEstoqueMinimo = value;
                OnPropertyChanged();
            }
        }

        private bool _exibirMensagemValidacaoEstoqueMinimo;
        public bool ExibirMensagemValidacaoEstoqueMinimo
        {
            get { return _exibirMensagemValidacaoEstoqueMinimo; }
            set
            {
                _exibirMensagemValidacaoEstoqueMinimo = value;
                OnPropertyChanged();
            }
        }


        //------------------------------------------------------------------
                                    //Commands
        //------------------------------------------------------------------


        public Command SalvarCommand
        {
            get
            {
                return new Command(() =>
                {
                    bool produtoValido = ValidarProduto();
                    bool modeloValido = ValidarModelo();
                    bool codigoValido = ValidarCodigo();
                    bool fornecedorValido = ValidarFornecedor();
                    bool quantidadeValida = ValidarQuantidade();
                    bool precoCompraValido = ValidarPrecoCompra();
                    bool precoVendaValido = ValidarPrecoVenda();
                    bool estoqueMinimoValido = ValidarEstoqueMinimo();

                    if (!produtoValido ||
                        !modeloValido ||
                        !codigoValido ||
                        !fornecedorValido ||
                        !quantidadeValida ||
                        !precoCompraValido ||
                        !precoVendaValido ||
                        !estoqueMinimoValido)
                    {
                        return;
                    }

                    if (produtoEdicao == null)
                    {
                        Produto novoProduto = new Produto
                        {
                            NomeProduto = Produto,
                            Modelo = Modelo,
                            Codigo = Codigo,
                            Fornecedor = Fornecedor,
                            Quantidade = int.Parse(Quantidade),
                            PrecoCompra = decimal.Parse(PrecoCompra),
                            PrecoVenda = decimal.Parse(PrecoVenda),
                            EstoqueMinimo = int.Parse(EstoqueMinimo)
                        };

                        ProdutoSingleton.Instancia.Produtos.Add(novoProduto);

                        Application.Current.MainPage.DisplayAlert(
                            "Sucesso",
                            "Produto cadastrado com sucesso!",
                            "OK");
                    }
                    else
                    {
                        produtoEdicao.NomeProduto = Produto;
                        produtoEdicao.Modelo = Modelo;
                        produtoEdicao.Codigo = Codigo;
                        produtoEdicao.Fornecedor = Fornecedor;
                        produtoEdicao.Quantidade = int.Parse(Quantidade);
                        produtoEdicao.PrecoCompra = decimal.Parse(PrecoCompra);
                        produtoEdicao.PrecoVenda = decimal.Parse(PrecoVenda);
                        produtoEdicao.EstoqueMinimo = int.Parse(EstoqueMinimo);

                        Application.Current.MainPage.DisplayAlert(
                            "Sucesso",
                            "Produto alterado com sucesso!",
                            "OK");
                    }
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

        //------------------------------------------------------------------
        //Validações
        //------------------------------------------------------------------

        public CadProdutoViewModel()
        {
        }

        public CadProdutoViewModel(Produto produto)
        {
            produtoEdicao = produto;

            Produto = produto.NomeProduto;
            Modelo = produto.Modelo;
            Codigo = produto.Codigo;
            Fornecedor = produto.Fornecedor;
            Quantidade = produto.Quantidade.ToString();
            PrecoCompra = produto.PrecoCompra.ToString();
            PrecoVenda = produto.PrecoVenda.ToString();
            EstoqueMinimo = produto.EstoqueMinimo.ToString();
        }

        private bool ValidarProduto()
        {
            if (string.IsNullOrWhiteSpace(Produto))
            {
                MensagemValidacaoNomeProduto = "O nome do produto é obrigatório.";
                ExibirValidacaoNomeProduto = true;
                return false;
            }

            else if (!Produto.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
            {
                MensagemValidacaoNomeProduto = "O nome possui caracteres inválidos.";
                ExibirValidacaoNomeProduto = true;
                return false;
            }
            return true;
        }


        private bool ValidarModelo()
        {
            if (string.IsNullOrWhiteSpace(Modelo))
            {
                MensagemValidacaoNomeProduto = "O nome do modelo é obrigatório.";
                ExibirValidacaoNomeProduto = true;
                return false;
            }
            else if (Modelo.Length < 3)
            {
                MensagemValidacaoCodigo = "O modelo do produto deve ter pelo menos 3 caracteres.";
                ExibirMensagemValidacaoCodigo = true;
                return false;
            }
            return true;
        }

        private bool ValidarCodigo()
        {
            if (string.IsNullOrWhiteSpace(Codigo))
            {
                MensagemValidacaoCodigo = "O código do produto é obrigatório.";
                ExibirMensagemValidacaoCodigo = true;
                return false;
            }
            else if (Codigo.Length < 3)
            {
                MensagemValidacaoCodigo = "O código do produto deve ter pelo menos 3 caracteres.";
                ExibirMensagemValidacaoCodigo = true;
                return false;
            }
            return true;
        }

        private bool ValidarFornecedor()
        {
            if (string.IsNullOrWhiteSpace(Fornecedor))
            {
                MensagemValidacaoFornecedor = "O fornecedor é obrigatório.";
                ExibirMensagemValidacaoFornecedor = true;
                return false;
            }
            else if (Fornecedor.Length < 3)
            {
                MensagemValidacaoFornecedor = "O fornecedor deve ter pelo menos 3 caracteres.";
                ExibirMensagemValidacaoFornecedor = true;
                return false;
            }
            return true;
        }

        private bool ValidarQuantidade()
        {
            if (string.IsNullOrWhiteSpace(Quantidade))
            {
                MensagemValidacaoQuantidade = "A quantidade é obrigatória.";
                ExibirMensagemValidacaoQuantidade = true;
                return false;
            }
            else if (!int.TryParse(Quantidade, out int quantidade))
            {
                MensagemValidacaoQuantidade = "Informe uma quantidade válida.";
                ExibirMensagemValidacaoQuantidade = true;
                return false;
            }
            else if (quantidade < 0)
            {
                MensagemValidacaoQuantidade = "A quantidade não pode ser negativa.";
                ExibirMensagemValidacaoQuantidade = true;
                return false;
            }
            return true;
        }

        private bool ValidarPrecoCompra()
        {
            if (string.IsNullOrWhiteSpace(PrecoCompra))
            {
                MensagemValidacaoPrecoCompra = "O preço de compra é obrigatório.";
                ExibirMensagemValidacaoPrecoCompra = true;
                return false;
            }
            else if (!decimal.TryParse(PrecoCompra, out decimal preco))
            {
                MensagemValidacaoPrecoCompra = "Informe um preço válido.";
                ExibirMensagemValidacaoPrecoCompra = true;
                return false;
            }
            else if (preco <= 0)
            {
                MensagemValidacaoPrecoCompra = "O preço de compra deve ser maior que zero.";
                ExibirMensagemValidacaoPrecoCompra = true;
                return false;
            }
            return true;
        }

        private bool ValidarPrecoVenda()
        {
            if (string.IsNullOrWhiteSpace(PrecoVenda))
            {
                MensagemValidacaoPrecoVenda = "O preço de venda é obrigatório.";
                ExibirMensagemValidacaoPrecoVenda = true;
                return false;
            }
            else if (!decimal.TryParse(PrecoVenda, out decimal preco))
            {
                MensagemValidacaoPrecoVenda = "Informe um preço válido.";
                ExibirMensagemValidacaoPrecoVenda = true;
                return false;
            }
            else if (preco <= 0)
            {
                MensagemValidacaoPrecoVenda = "O preço de venda deve ser maior que zero.";
                ExibirMensagemValidacaoPrecoVenda = true;
                return false;
            }
            return true;
        }

        private bool ValidarEstoqueMinimo()
        {
            if (string.IsNullOrWhiteSpace(EstoqueMinimo))
            {
                MensagemValidacaoEstoqueMinimo = "O estoque mínimo é obrigatório.";
                ExibirMensagemValidacaoEstoqueMinimo = true;
                return false;
            }
            else if (!int.TryParse(EstoqueMinimo, out int estoque))
            {
                MensagemValidacaoEstoqueMinimo = "Informe uma quantidade válida.";
                ExibirMensagemValidacaoEstoqueMinimo = true;
                return false;
            }
            else if (estoque < 0)
            {
                MensagemValidacaoEstoqueMinimo = "O estoque mínimo não pode ser negativo.";
                ExibirMensagemValidacaoEstoqueMinimo = true;
                return false;
            }
            return true;
        }
    }
}
