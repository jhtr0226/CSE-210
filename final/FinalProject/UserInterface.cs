using System.ComponentModel.Design;

public class UserInterface
{




    public void Menu()
    {

        string option = "";
        while (option != "5")
        {

            Console.Write("Options:\n  1.Create New Patient\n  2.Appointments Selection\n  3.Records\n  4.Billing Selection\n  5.Quit\nSelect a choice from the menu: ");
            //Console.Write("Options:\n  1.Create New Patient\n  2.Appointments Selection\n  3.Records\n  4.Billing Selection\n  5.Quit\n  6.Delete Goal\n  7.Quit\nSelect a choice from the menu: ");
            option = Console.ReadLine();
            Console.Clear();
            if (option == "1")
            {

            }
            else if (option == "2") // Appointments
            {
                Console.Write("What should we do today?\n1.Schedule and appointment\n2.Cancel/Reschedule an appointment\n3.View appointment information\nSelect an option: ");
                string aOne = Console.ReadLine();
                if (aOne == "1")
                {

                }
            }
            else if (option == "3")
            {
                Console.Write("Select an option!\n1.");
            }
            else if (option == "4")
            {

            }
            else if (option == "5")
            {

            }
            else
            {

            }


        }


    }
}