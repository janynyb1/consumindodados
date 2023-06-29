using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows;

namespace Consumindo_WebAPI_Estudantes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HttpClient client = new HttpClient();

        public MainWindow()
        {
            InitializeComponent();
            List<string> generoLista = new List<string>();
            generoLista.Add("Masculino");
            generoLista.Add("Feminino");
            cbxGenero.ItemsSource = generoLista;

            client.BaseAddress = new Uri("http://localhost:51133");
            NewMethod2();

            this.Loaded += MainWindow_Loaded;
        }

        private void NewMethod2()
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("/api/estudantes");
                response.EnsureSuccessStatusCode(); // Lança um código de erro
                var estudantes = await response.Content.ReadAsAsync<IEnumerable<Estudante>>();
                estudantesListView.ItemsSource = estudantes;
            }
            catch
            {
                //throw;
            }
        }

        private async void btnGetEstudante_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("/api/estudantes/" + txtID.Text);
                response.EnsureSuccessStatusCode(); //lança um código de erro
                var estudantes = await response.Content.ReadAsAsync<Estudante>();
                estudanteDetalhesPanel.Visibility = Visibility.Visible;
                estudanteDetalhesPanel.DataContext = estudantes;
            }
            catch (Exception)
            {
                MessageBox.Show("Estudante não localizado");
            }
        }

        private async void btnNovoEstudante_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var estudante = new Estudante()
                {
                    nome = txtNomeEstudante.Text,
                    id = int.Parse(txtIDEstudante.Text),
                    genero = cbxGenero.SelectedItem.ToString(),
                    idade = int.Parse(txtIdade.Text)
                };
                var response = await NewMethod(estudante);
                response.EnsureSuccessStatusCode(); //lança um código de erro
                MessageBox.Show("Estudante incluído com sucesso", "Result", MessageBoxButton.OK, MessageBoxImage.Information);
                estudantesListView.ItemsSource = await GetAllEstudantes();
                estudantesListView.ScrollIntoView(estudantesListView.ItemContainerGenerator.Items[estudantesListView.Items.Count - 1]);
            }
            catch (Exception)
            {
                MessageBox.Show("O Estudante não foi incluído. (Verifique se o ID não esta duplicado)");
            }
        }

        private Task<HttpResponseMessage> NewMethod(Estudante estudante)
        {
            return NewMethod1(estudante);
        }

        private Task<HttpResponseMessage> NewMethod1(Estudante estudante)
        {
            return client.PutAsJsonAsync;
        }

        private async void btnAtualiza_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var estudante = new Estudante()
                {
                    nome = txtNomeEstudante.Text,
                    id = int.Parse(txtIDEstudante.Text),
                    genero = cbxGenero.SelectedItem.ToString(),
                    idade = int.Parse(txtIdade.Text)
                };
                object response = await NewMethod3(estudante);
                NewMethod4(response);
                MessageBox.Show("Estudante atualizado com sucesso", "Result", MessageBoxButton.OK, MessageBoxImage.Information);
                estudantesListView.ItemsSource = await GetAllEstudantes();
                estudantesListView.ScrollIntoView(estudantesListView.ItemContainerGenerator.Items[estudantesListView.Items.Count - 1]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void NewMethod4(object response)
        {
            response.EnsureSuccessStatusCode(); //lança um código de erro
        }

        private async Task<object> NewMethod3(Estudante estudante)
        {
            return await client.PutAsJsonAsync("/api/estudantes/", estudante);
        }

        private async void btnDeletEstudante_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync("/api/estudantes/" + txtID.Text);
                response.EnsureSuccessStatusCode(); //lança um código de erro
                MessageBox.Show("Estudante deletado com sucesso");
                estudantesListView.ItemsSource = await GetAllEstudantes();
                estudantesListView.ScrollIntoView(estudantesListView.ItemContainerGenerator.Items[estudantesListView.Items.Count - 1]);
            }
            catch (Exception)
            {
                MessageBox.Show("Estudante deletado com sucesso");
            }
        }

        public async Task<IEnumerable<Estudante>> GetAllEstudantes()
        {
            HttpResponseMessage response = await client.GetAsync("/api/estudantes");
            response.EnsureSuccessStatusCode(); //lança um código de erro
            var estudantes = await response.Content.ReadAsAsync<IEnumerable<Estudante>>();
            return estudantes;
        }
    }
}
