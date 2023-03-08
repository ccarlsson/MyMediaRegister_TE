using MyMediaRegister_TE.Models;
using System.Windows;
using System.Collections.Generic;

namespace MyMediaRegister_TE;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private List<Media> _medias = new List<Media>();

    public MainWindow()
    {
        InitializeComponent();
    }

    private void AddBook_Click(object sender, RoutedEventArgs e)
    {
        string title = tbxBookTitle.Text;
        string author = tbxAuthor.Text;
        int pages = int.Parse(tbxPages.Text);

        Book book = new Book(title, author, pages);
        
        _medias.Add(book);
        listbox.Items.Add(book);
    }

    private void AddMovie_Click(object sender, RoutedEventArgs e)
    {
        string title = tbxMoveTitle.Text;
        string director = tbxDirector.Text;
        int minutes = int.Parse(tbxLength.Text);

        Movie movie = new Movie(title, director, minutes);

        _medias.Add(movie);
        listbox.Items.Add(movie);
    }
}
