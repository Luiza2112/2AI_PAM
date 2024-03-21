using System.Runtime.CompilerServices;

namespace Projeto;

public partial class NotePage : ContentPage
{
	string content = "";
	string path = Path.Combine(FileSystem.AppDataDirectory, "note.txt");
	public NotePage()
	{
		InitializeComponent();
	}

	private void SaveButton_Clicked(object sender, EventArgs e)
	{
		content = NoteEditor.Text;
		File.WriteAllText(path, content);
	}

	private void DeleteButton_Clicked(object sender, EventArgs e)
	{ 
	
	}
}