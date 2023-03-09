using MyMediaRegister_TE.Models;
using System.Windows;
using System.Collections.Generic;
using System.Windows.Controls;

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
        rbAll.IsChecked = true;
    }

    private void AddBook_Click(object sender, RoutedEventArgs e)
    {
        string title = tbxBookTitle.Text;
        string author = tbxAuthor.Text;
        int pages = int.Parse(tbxPages.Text);

        Book book = new Book(title, author, pages);
        
        _medias.Add(book);
        UpdateListBox();
    }

    private void AddMovie_Click(object sender, RoutedEventArgs e)
    {
        string title = tbxMoveTitle.Text;
        string director = tbxDirector.Text;
        int minutes = int.Parse(tbxLength.Text);

        Movie movie = new Movie(title, director, minutes);

        _medias.Add(movie);
        UpdateListBox();
    }

    private void UpdateListBox()
    {
        listbox.Items.Clear();

        foreach (Media media in _medias)
        {
            if (rbMovies.IsChecked == true && media is Movie)
            {
                listbox.Items.Add(media);
            }
            else if (rbBooks.IsChecked == true && media is Book)
            {
                listbox.Items.Add(media);
            }
            else if (rbAll.IsChecked == true)
            {
                listbox.Items.Add(media);
            }
        }

    }
    private void Rb_Checked(object sender, RoutedEventArgs e)
    {
        UpdateListBox();
    }
}
