using System.Runtime.CompilerServices;

namespace Projeto;

public partial class NotePage : ContentPage
{
	//DCIM/MEDIA/com.whatsapp.media
	string content = "";
	string path = Path.Combine(FileSystem.AppDataDirectory, "note.txt");
	//path = caminho
	public NotePage()
	{
		InitializeComponent();
		//Verifica se o arquivo existe
		if (File.Exists(path))
		{
			//Carrega o conteúdo do arquivo no editor de texto
			NoteEditor.Text = File.ReadAllText(path);
		}
	}

	private void SaveButton_Clicked(object sender, EventArgs e)
	{
		//Pegar o conteúdo que o usuário escreveu.
		content = NoteEditor.Text;

		//Criar o arquivo com o conteúdo
		File.WriteAllText(path, content);
        DisplayAlert("Sucesso", "Arquivo criado com sucesso", "OK");
    }

	private void DeleteButton_Clicked(object sender, EventArgs e)
	{ 
		//Verificar se o arquivo existe.
		if (File.Exists(path))
		{
			//Exibir mensagem
			File.Delete(path);
			NoteEditor.Text = "";
			DisplayAlert("Sucesso", "Arquivo deletado com sucesso", "OK");
		}
	}
}