//---------------------Start--------------------//
using Animals.Models;

PetShop petShop = new PetShop();


bool bool1 = true;  

string[] menu = { "Dogs", "Cats", "Birds", "Fishes","Exit" };
string[] menu2 =  { "Play", "Sleep", "Eat", "Exit" };
int index = 0;
int index1 = 0;
while (bool1)
{
    Animal? animal = null;
    Console.Clear();
    Console.Write("\n\n\n\n\n\n\n\n\n");
    for (int i = 0; i < menu.Length; i++)
    {
        if (i == index)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\t\t\t\t\t\t\t" + menu[i] + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.Write("\t\t\t\t\t\t\t" + menu[i] + "\n");
        }

    }

    ConsoleKeyInfo keyInfo = Console.ReadKey();
    if (keyInfo.Key == ConsoleKey.UpArrow)
    {
        if (index != 0)
        {
            index--;
        }
        else
        {
            index = menu.Length;
        }
    }
    if (keyInfo.Key == ConsoleKey.DownArrow)
    {
        if (index != menu.Length)
        {
            index++;
        }
        else
        {
            index = 0;
        }
    }

    if (keyInfo.Key == ConsoleKey.Enter)
    {
        switch (index)
        {
            case 0:
                {
                    Console.Clear();
                    foreach (var i in petShop.dogs )
                    {
                        Console.WriteLine(i.Name);
                    }
                    Console.WriteLine("Choose your friend:");
                    string? name = Console.ReadLine();
                    if (name != null)
                    {
                         animal = petShop.ReturnByNickNameDog(name);

                    }
                    if (animal.Name != null)
                    {
                        bool bool2 = true;
                        while (bool2)
                        {
                            Console.Clear();
                        
                            Console.WriteLine(animal);
                            ;
                           
                            Console.Write("\n\n\n\n\n\n\n\n\n");
                            for (int i = 0; i < menu2.Length; i++)
                            {
                                if (i == index1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("\t\t\t\t\t\t\t" + menu2[i] + "\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    Console.Write("\t\t\t\t\t\t\t" + menu2[i] + "\n");
                                }

                            }

                            ConsoleKeyInfo keyInfo2 = Console.ReadKey();
                            if (keyInfo2.Key == ConsoleKey.UpArrow)
                            {
                                if (index1 != 0)
                                {
                                    index1--;
                                }
                                else
                                {
                                    index1 = menu2.Length;
                                }
                            }
                            if (keyInfo2.Key == ConsoleKey.DownArrow)
                            {
                                if (index1 != menu2.Length)
                                {
                                    index1++;
                                }
                                else
                                {
                                    index1 = 0;
                                }
                            }
                            if (keyInfo2.Key == ConsoleKey.Enter)
                            {
                                switch (index1)
                                {

                                    case 0:
                                        {
                                            animal.Play();
                                            break;
                                        }

                                    case 1:
                                        {
                                            animal.Sleep();
                                            break;
                                        }

                                    case 2:
                                        {
                                            animal.Eat();
                                            break;
                                        }

                                    case 3:
                                        {
                                            
                                            bool2 = false;
                                            break;
                                        }


                                }
                            }

                        }
                    }
                   
                    break;
                }
            case 1:
                {
                    Console.Clear();
                    foreach (var i in petShop.cats)
                    {
                        Console.WriteLine(i.Name);
                    }
                    Console.WriteLine("Choose your friend:");
                    string? name = Console.ReadLine();
                    if (name != null)
                    {
                        animal = petShop.ReturnByNickNameCat(name);

                    }
                    if (animal.Name != null)
                    {
                        bool bool2 = true;
                        while (bool2)
                        {
                            Console.Clear();

                            Console.WriteLine(animal);
                            ;

                            Console.Write("\n\n\n\n\n\n\n\n\n");
                            for (int i = 0; i < menu2.Length; i++)
                            {
                                if (i == index1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("\t\t\t\t\t\t\t" + menu2[i] + "\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    Console.Write("\t\t\t\t\t\t\t" + menu2[i] + "\n");
                                }

                            }

                            ConsoleKeyInfo keyInfo2 = Console.ReadKey();
                            if (keyInfo2.Key == ConsoleKey.UpArrow)
                            {
                                if (index1 != 0)
                                {
                                    index1--;
                                }
                                else
                                {
                                    index1 = menu2.Length;
                                }
                            }
                            if (keyInfo2.Key == ConsoleKey.DownArrow)
                            {
                                if (index1 != menu2.Length)
                                {
                                    index1++;
                                }
                                else
                                {
                                    index1 = 0;
                                }
                            }
                            if (keyInfo2.Key == ConsoleKey.Enter)
                            {
                                switch (index1)
                                {

                                    case 0:
                                        {
                                            animal.Play();
                                            break;
                                        }

                                    case 1:
                                        {
                                            animal.Sleep();
                                            break;
                                        }

                                    case 2:
                                        {
                                            animal.Eat();
                                            break;
                                        }

                                    case 3:
                                        {

                                            bool2 = false;
                                            break;
                                        }


                                }
                            }

                        }
                    }

                    break;
                }
            case 2:
                {
                    Console.Clear();
                    foreach (var i in petShop.birds)
                    {
                        Console.WriteLine(i.Name);
                    }
                    Console.WriteLine("Choose your friend:");
                    string? name = Console.ReadLine();
                    if (name != null)
                    {
                        animal = petShop.ReturnByNickNameBird(name);

                    }
                    if (animal.Name != null)
                    {
                        bool bool2 = true;
                        while (bool2)
                        {
                            Console.Clear();

                            Console.WriteLine(animal);
                            ;

                            Console.Write("\n\n\n\n\n\n\n\n\n");
                            for (int i = 0; i < menu2.Length; i++)
                            {
                                if (i == index1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("\t\t\t\t\t\t\t" + menu2[i] + "\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    Console.Write("\t\t\t\t\t\t\t" + menu2[i] + "\n");
                                }

                            }

                            ConsoleKeyInfo keyInfo2 = Console.ReadKey();
                            if (keyInfo2.Key == ConsoleKey.UpArrow)
                            {
                                if (index1 != 0)
                                {
                                    index1--;
                                }
                                else
                                {
                                    index1 = menu2.Length;
                                }
                            }
                            if (keyInfo2.Key == ConsoleKey.DownArrow)
                            {
                                if (index1 != menu2.Length)
                                {
                                    index1++;
                                }
                                else
                                {
                                    index1 = 0;
                                }
                            }
                            if (keyInfo2.Key == ConsoleKey.Enter)
                            {
                                switch (index1)
                                {

                                    case 0:
                                        {
                                            animal.Play();
                                            break;
                                        }

                                    case 1:
                                        {
                                            animal.Sleep();
                                            break;
                                        }

                                    case 2:
                                        {
                                            animal.Eat();
                                            break;
                                        }

                                    case 3:
                                        {

                                            bool2 = false;
                                            break;
                                        }


                                }
                            }

                        }
                    }

                    break;
                }
            case 3:
                {
                    Console.Clear();
                    foreach (var i in petShop.fishes)
                    {
                        Console.WriteLine(i.Name);
                    }
                    Console.WriteLine("Choose your friend:");
                    string? name = Console.ReadLine();
                    if (name != null)
                    {
                        animal = petShop.ReturnByNickNameFish(name);

                    }
                    if (animal.Name != null)
                    {
                        bool bool2 = true;
                        while (bool2)
                        {
                            Console.Clear();

                            Console.WriteLine(animal);
                            ;

                            Console.Write("\n\n\n\n\n\n\n\n\n");
                            for (int i = 0; i < menu2.Length; i++)
                            {
                                if (i == index1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("\t\t\t\t\t\t\t" + menu2[i] + "\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    Console.Write("\t\t\t\t\t\t\t" + menu2[i] + "\n");
                                }

                            }

                            ConsoleKeyInfo keyInfo2 = Console.ReadKey();
                            if (keyInfo2.Key == ConsoleKey.UpArrow)
                            {
                                if (index1 != 0)
                                {
                                    index1--;
                                }
                                else
                                {
                                    index1 = menu2.Length;
                                }
                            }
                            if (keyInfo2.Key == ConsoleKey.DownArrow)
                            {
                                if (index1 != menu2.Length)
                                {
                                    index1++;
                                }
                                else
                                {
                                    index1 = 0;
                                }
                            }
                            if (keyInfo2.Key == ConsoleKey.Enter)
                            {
                                switch (index1)
                                {

                                    case 0:
                                        {
                                            animal.Play();
                                            break;
                                        }

                                    case 1:
                                        {
                                            animal.Sleep();
                                            break;
                                        }

                                    case 2:
                                        {
                                            animal.Eat();
                                            break;
                                        }

                                    case 3:
                                        {

                                            bool2 = false;
                                            break;
                                        }


                                }
                            }

                        }
                    }

                    break;
                }
            case 4:
                {
                    bool1 = false;
                    break;
                }
            default:
                {
                    break;
                }
        }
    }
}


