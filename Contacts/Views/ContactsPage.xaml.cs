namespace Contacts.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();

        List<Contact> contacts = new List<Contact> {
            new Contact { Name = "Alla", Email = "alla@gmail.com" },
            new Contact { Name = "Andru", Email = "andru@gmail.com" },
            new Contact { Name = "Max", Email = "max@gmail.com" },
        };

        ListContact.ItemsSource = contacts;
    }
}

public class Contact
{
    public string Name { get; set; }
    public string Email { get; set; }
}