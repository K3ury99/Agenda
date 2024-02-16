Console.WriteLine("---Mi Agenda---");
Console.WriteLine("---Bienvenido a tu lista de contactos");

List<int> ids = new List<int>();
List<string> names = new List<string>();
List<string> phones = new List<string>();
List<string> emails = new List<string>();
List<string> addresses = new List<string>();

bool running = true;
while (running)
{
    Console.WriteLine("1. Agregar Contacto");
    Console.WriteLine("2. Ver Contactos");
    Console.WriteLine("3. Buscar Contactos");
    Console.WriteLine("4. Modificar Contacto");
    Console.WriteLine("5. Eliminar Contacto");
    Console.WriteLine("6. Salir");
    Console.Write("Elige una opción: ");

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            AddContact(names, phones, emails, addresses, ids);
            break;
        case 2:
            ViewContacts(names, phones, emails, addresses, ids);
            break;
        case 3:
            SearchContact(names, phones, emails, addresses, ids);
            break;
        case 4:
            EditContact(names, phones, emails, addresses, ids);
            break;
        case 5:
            DeleteContact(names, phones, emails, addresses, ids);
            break;
        case 6:
            running = false;
            break;
        default:
            Console.WriteLine("Opción no válida...");
            break;
    }
}



static void AddContact(List<string> names, List<string> phones, List<string> emails, List<string> addresses, List<int> ids)
{
    Console.WriteLine("\n-Ingrese el nombre: ");
    string name = Console.ReadLine() ??"";

    Console.Write("-Ingrese el teléfono: ");
    string phone = Console.ReadLine() ??"";

    Console.Write("-Ingrese el correo electrónico: ");
    string email = Console.ReadLine() ??"";

    Console.Write("-Ingrese la dirección: ");
    string address = Console.ReadLine() ??"";

    // Genera un ID único
    int id = ids.Count + 1;

    // Agrega los datos a las listas
    names.Add(name);
    phones.Add(phone);
    emails.Add(email);
    addresses.Add(address);
    ids.Add(id);

    Console.WriteLine("");
    Console.WriteLine("---Contacto agregado correctamente.\n");
}





static void ViewContacts(List<string> names, List<string> phones, List<string> emails, List<string> addresses, List<int> ids)
{
    Console.WriteLine("\nLista de Contactos:");
    for (int i = 0; i < ids.Count; i++)
    {
        Console.WriteLine($"ID: {ids[i]}, Nombre: {names[i]}, Teléfono: {phones[i]}, Email: {emails[i]}, Dirección: {addresses[i]}");
    }
    Console.WriteLine();
}




// Muestra todos los datos
static void PrintContactDetails(List<string> names, List<string> phones, List<string> emails, List<string> addresses, List<int> ids, int index)
{
    Console.WriteLine($"ID: {ids[index]}, Nombre: {names[index]}, Teléfono: {phones[index]}, Email: {emails[index]}, Dirección: {addresses[index]}\n");
}

static void SearchContact(List<string> names, List<string> phones, List<string> emails, List<string> addresses, List<int> ids)
{
    Console.WriteLine("\n---Opciones de búsqueda---");
    Console.WriteLine("1. Buscar por ID");
    Console.WriteLine("2. Buscar por Nombre");
    Console.WriteLine("3. Buscar por Teléfono");
    Console.WriteLine("4. Buscar por Email");
    Console.WriteLine("5. Buscar por Dirección");
    Console.Write("Seleccione una opción: ");

    int searchOption = Convert.ToInt32(Console.ReadLine());

    switch (searchOption)
    {
        case 1:
            SearchById(names, phones, emails, addresses, ids);
            break;
        case 2:
            SearchByName(names, phones, emails, addresses, ids);
            break;
        case 3:
            SearchByPhone(names, phones, emails, addresses, ids);
            break;
        case 4:
            SearchByEmail(names, phones, emails, addresses, ids);
            break;
        case 5:
            SearchByAddress(names, phones, emails, addresses, ids);
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}

static void SearchById(List<string> names, List<string> phones, List<string> emails, List<string> addresses, List<int> ids)
{
    Console.Write("Ingrese el ID del contacto a buscar: ");
    int searchId = Convert.ToInt32(Console.ReadLine());

    int index = ids.IndexOf(searchId);

    if (index != -1)
    {
        PrintContactDetails(names, phones, emails, addresses, ids, index);
    }
    else
    {
        Console.WriteLine("---Contacto no encontrado.\n");
    }
}

static void SearchByName(List<string> names, List<string> phones, List<string> emails, List<string> addresses, List<int> ids)
{
    Console.Write("Ingrese el nombre del contacto a buscar: ");
    string searchName = Console.ReadLine() ??"";

    int index = names.IndexOf(searchName);

    if (index != -1)
    {
        PrintContactDetails(names, phones, emails, addresses, ids, index);
    }
    else
    {
        Console.WriteLine("---Contacto no encontrado.\n");
    }
}

static void SearchByPhone(List<string> names, List<string> phones, List<string> emails, List<string> addresses, List<int> ids)
{
    Console.Write("Ingrese el telefono del contacto a buscar: ");
    string searchPhone = Console.ReadLine() ??"";

    int index = phones.IndexOf(searchPhone);

    if (index != -1)
    {
        PrintContactDetails(names, phones, emails, addresses, ids, index);
    }
    else
    {
        Console.WriteLine("Contacto no encontrado.\n");
    }
}

static void SearchByEmail(List<string> names, List<string> phones, List<string> emails, List<string> addresses, List<int> ids)
{
    Console.Write("Ingrese el telefono del contacto a buscar: ");
    string searchEmail = Console.ReadLine() ??"";

    int index = emails.IndexOf(searchEmail);

    if (index != -1)
    {
        PrintContactDetails(names, phones, emails, addresses, ids, index);
    }
    else
    {
        Console.WriteLine("Contacto no encontrado.\n");
    }
}

static void SearchByAddress(List<string> names, List<string> phones, List<string> emails, List<string> addresses, List<int> ids)
{
    Console.Write("Ingrese el telefono del contacto a buscar: ");
    string searchAddress = Console.ReadLine() ??"";

    int index = addresses.IndexOf(searchAddress);

    if (index != -1)
    {
        PrintContactDetails(names, phones, emails, addresses, ids, index);
    }
    else
    {
        Console.WriteLine("Contacto no encontrado.\n");
    }
}







static void EditContact(List<string> names, List<string> phones, List<string> emails, List<string> addresses, List<int> ids)
{
    Console.WriteLine("\n---Ingrese el nombre del contacto a editar: ");
    string editName = Console.ReadLine() ??"";

    int index = names.IndexOf(editName);

    if (index != -1)
    {
        Console.WriteLine($"Editando contacto - ID: {ids[index]}, Nombre: {names[index]}, Teléfono: {phones[index]}, Email: {emails[index]}, Dirección: {addresses[index]}");

        Console.Write("-Nuevo nombre: ");
        names[index] = Console.ReadLine() ??"";

        Console.Write("-Nuevo teléfono: ");
        phones[index] = Console.ReadLine() ??"";

        Console.Write("-Nuevo correo electrónico: ");
        emails[index] = Console.ReadLine() ??"";

        Console.Write("-Nueva dirección: ");
        addresses[index] = Console.ReadLine() ??"";

        Console.WriteLine("-Contacto editado correctamente.\n");
    }
    else
    {
        Console.WriteLine("-Contacto no encontrado.\n");
    }
}




static void DeleteContact(List<string> names, List<string> phones, List<string> emails, List<string> addresses, List<int> ids)
{
    Console.Write("\n---Ingrese el nombre del contacto a eliminar: ");
    string deleteName = Console.ReadLine() ??"";

    int index = names.IndexOf(deleteName);

    if (index != -1)
    {
        Console.WriteLine($"Eliminando contacto - ID: {ids[index]}, Nombre: {names[index]}, Teléfono: {phones[index]}, Email: {emails[index]}, Dirección: {addresses[index]}");

        // Eliminar el contacto de todas las listas
        names.RemoveAt(index);
        phones.RemoveAt(index);
        emails.RemoveAt(index);
        addresses.RemoveAt(index);
        ids.RemoveAt(index);

        Console.WriteLine("---Contacto eliminado correctamente.\n");
    }
    else
    {
        Console.WriteLine("---Contacto no encontrado.\n");
    }
}




//Creditos: Keury Ramirez. Matricula: 2023-1101.