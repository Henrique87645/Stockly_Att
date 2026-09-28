using System;
using System.Linq;

namespace AppStockly.ViewModels
{
    public class CadLoginViewModel : BaseNotifyViewModel
    {
        //Login
        private string _loginName;

        public string LoginName
        {
            get { return _loginName; }

            set
            {
                _loginName = value;
                OnPropertyChanged(nameof(LoginName));
            }
        }

        private string _mensagemValidacaoLoginName;

        public string MensagemValidacaoLoginName
        {
            get { return _mensagemValidacaoLoginName; }

            set
            {
                _mensagemValidacaoLoginName = value;
                OnPropertyChanged();
            }
        }

        private bool _exibirMensagemErroLoginName;

        public bool ExibirMensagemErroLoginName
        {
            get { return _exibirMensagemErroLoginName; }

            set
            {
                _exibirMensagemErroLoginName = value;
                OnPropertyChanged();
            }
        }


        //Email
        private string _email;

        public string Email
        {
            get { return _email; }

            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        private string _mensagemvalidacaoemail;

        public string MensagemValidacaoEmail
        {
            get { return _mensagemvalidacaoemail; }

            set
            {
                _mensagemvalidacaoemail = value;
                OnPropertyChanged();
            }
        }

        private bool _exibirmensagemerroemail;

        public bool ExibirMensagemErroEmail
        {
            get { return _exibirmensagemerroemail; }

            set
            {
                _exibirmensagemerroemail = value;
                OnPropertyChanged();
            }
        }


        //Senha
        private string _senha;

        public string Senha
        {
            get { return _senha; }

            set
            {
                _senha = value;
                OnPropertyChanged(nameof(Senha));
            }
        }

        private string _mensagemvalidacaosenha;

        public string MensagemValidacaoSenha
        {
            get { return _mensagemvalidacaosenha; }

            set
            {
                _mensagemvalidacaosenha = value;
                OnPropertyChanged();
            }
        }

        private bool _exibirmensagemerrosenha;

        public bool ExibirMensagemErroSenha
        {
            get { return _exibirmensagemerrosenha; }

            set
            {
                _exibirmensagemerrosenha = value;
                OnPropertyChanged();
            }
        }

        //------------------------------------------------------------------
        //Commands 
        //------------------------------------------------------------------
        public Command btnCadastrar
        {
            get
            {
                return new Command(() =>
                {
                    ValidarUserName();
                    ValidarEmail();
                    ValidarSenha();
                });
            }
        }



        public Command btnEntrar
        {
            get
            {
                return new Command(() =>
                {
                    bool loginValido = ValidarUserName();
                    bool emailValido = ValidarEmail();
                    bool senhaValida = ValidarSenha();

                    if (loginValido && emailValido && senhaValida)
                    {
                        Entrar();
                    }
                });
            }
        }

        //------------------------------------------------------------------
        //Validações
        //------------------------------------------------------------------
        private void Entrar()
        {
            Application.Current.MainPage =
                new NavigationPage(new MainPage());
        }

        private bool ValidarUserName()
        {
            if (string.IsNullOrWhiteSpace(LoginName))
            {
                MensagemValidacaoLoginName = "Campo obrigatório";
                ExibirMensagemErroLoginName = true;

                return false;
            }

            else if (LoginName.Length < 5)
            {
                MensagemValidacaoLoginName =
                    "O User Name deve ter no mínimo 5 caracteres.";

                ExibirMensagemErroLoginName = true;

                return false;
            }

            else if (LoginName.Any(char.IsWhiteSpace))
            {
                MensagemValidacaoLoginName =
                    "O User Name não pode conter espaços.";

                ExibirMensagemErroLoginName = true;

                return false;
            }

            else if (LoginName != "Admin")
            {
                MensagemValidacaoLoginName =
                    "Login incorreto";

                ExibirMensagemErroLoginName = true;

                return false;
            }

            else
            {
                ExibirMensagemErroLoginName = false;

                return true;
            }
        }

        private bool ValidarEmail()
        {
            if (string.IsNullOrWhiteSpace(Email))
            {
                MensagemValidacaoEmail = "Campo obrigatório";
                ExibirMensagemErroEmail = true;

                return false;
            }

            else if (!Email.Contains("@stockly.com"))
            {
                MensagemValidacaoEmail = "Domínio inválido";

                ExibirMensagemErroEmail = true;

                return false;
            }

            else if (Email != "admin@stockly.com")
            {
                MensagemValidacaoEmail = "E-mail incorreto";

                ExibirMensagemErroEmail = true;

                return false;
            }

            else
            {
                ExibirMensagemErroEmail = false;

                return true;
            }
        }

        private bool ValidarSenha()
        {
            if (string.IsNullOrWhiteSpace(Senha))
            {
                MensagemValidacaoSenha = "Campo obrigatório";

                ExibirMensagemErroSenha = true;

                return false;
            }

            else if (Senha.Length < 8)
            {
                MensagemValidacaoSenha =
                    "Senha deve conter no mínimo 8 caracteres";

                ExibirMensagemErroSenha = true;

                return false;
            }

            else if (Senha != "Admin@123")
            {
                MensagemValidacaoSenha =
                    "Senha incorreta";

                ExibirMensagemErroSenha = true;

                return false;
            }

            else
            {
                ExibirMensagemErroSenha = false;

                return true;
            }
        }
    }
}